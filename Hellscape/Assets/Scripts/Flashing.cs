using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public GameObject objectflash;
    public static bool flash = false;


    // Update is called once per frame
    void Update()
    {
        if (flash)    
            objectflash.SetActive (false);
        else
       
        objectflash.SetActive(true);
    }
}
