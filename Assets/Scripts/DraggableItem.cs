using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Sorting srt;
    Audio au;
    [HideInInspector] public Transform parentAfterDrag;
    public Image image;
    public void Start()
    {
        srt = GameObject.FindObjectOfType<Sorting>();
        au = GameObject.FindObjectOfType<Audio>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        au.takef();
        if (transform.parent.tag == "inventory")
        {
            for (int i = 0; i < 20; i++)
            {
                srt.Sort();

            }
        }
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        au.dropf();
        image.raycastTarget = true;
        if (transform.parent.tag == "delete")
        {
            Destroy(gameObject);
        }
        else
        {
            
        }
        for (int i = 0; i < 20; i++)
        {
            srt.control();

        }

    }

}
