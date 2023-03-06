using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Audio : MonoBehaviour
{
    [HideInInspector] public Transform parentAfterDrag;
    public AudioSource take;
    public AudioSource drop;
    public void Start()
    {
       
    }

    public void takef()
    {
        take.Play();
    }


    public void dropf()
    {
        drop.Play();
    }

}
