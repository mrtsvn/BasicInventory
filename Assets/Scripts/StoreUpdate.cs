using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StoreUpdate : MonoBehaviour
{
    public GameObject[] obj = new GameObject[3];
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        SpawnItem();

    }
    void SpawnItem()
    {
        if (transform.childCount==0 && !Input.GetMouseButton(0))
        {
            
            var newobj = Instantiate(obj[Random.Range(0, 3)]);
            newobj.transform.parent = gameObject.transform;
        }
      
        else
        {

        }
    }
}
