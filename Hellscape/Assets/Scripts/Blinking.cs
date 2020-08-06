using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{

    public GameObject objectflash;

    

     void Start()
    {
        objectflash.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (objectflash.activeSelf == true)
            {
                objectflash.SetActive(false);
            }
            else
            {
                objectflash.SetActive(true);
            }
        }
    } 
}


   

