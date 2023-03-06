using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorting : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;
    public GameObject Slot6;
    public GameObject Slot7;
    public GameObject Slot8;
    
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Sort()
    {
        
        if (Slot1.transform.childCount >= Slot2.transform.childCount)
        {

        }
        else
        {
            GameObject object1 = Slot2.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot1.transform;
        }

        if (Slot2.transform.childCount >= Slot3.transform.childCount)
        {

        }
        else
        {
            GameObject object1 = Slot3.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot2.transform;
        }

        if (Slot3.transform.childCount >= Slot4.transform.childCount)
        {

        }
        else
        {
            GameObject object1 = Slot4.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot3.transform;
        }

        if (Slot4.transform.childCount >= Slot5.transform.childCount)
        {

        }
        else
        {
            GameObject object1 = Slot5.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot4.transform;
        }

        if (Slot5.transform.childCount >= Slot6.transform.childCount)
        {

        }
        else
        {
            GameObject object1 = Slot6.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot5.transform;
        }

        if (Slot6.transform.childCount >= Slot7.transform.childCount)
        {

        }
        else
        {
            GameObject object1 = Slot7.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot6.transform;
        }

        if (Slot7.transform.childCount >= Slot8.transform.childCount)
        {

        }
        else
        {
            GameObject object1 = Slot8.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot7.transform;
        }
        
    }

    public void control()
    {
        if (Slot1.transform.childCount > 1)
        {
            GameObject object1 = Slot1.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot2.transform;
        }
        else
        {
           
        }

        if (Slot2.transform.childCount > 1)
        {
            GameObject object1 = Slot2.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot3.transform;
        }
        else
        {

        }

        if (Slot3.transform.childCount > 1)
        {
            GameObject object1 = Slot3.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot4.transform;
        }
        else
        {

        }

        if (Slot4.transform.childCount > 1)
        {
            GameObject object1 = Slot4.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot5.transform;
        }
        else
        {

        }

        if (Slot5.transform.childCount > 1)
        {
            GameObject object1 = Slot5.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot6.transform;
        }
        else
        {

        }

        if (Slot6.transform.childCount > 1)
        {
            GameObject object1 = Slot6.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot7.transform;
        }
        else
        {

        }

        if (Slot7.transform.childCount > 1)
        {
            GameObject object1 = Slot7.transform.GetChild(0).gameObject;
            object1.transform.parent = Slot8.transform;
        }
        else
        {

        }
    }
}

     

