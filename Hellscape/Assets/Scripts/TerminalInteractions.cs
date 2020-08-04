using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalInteractions : MonoBehaviour
{


    private bool inposition = false;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && inposition == true)
        {

        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        inposition = true;
    }






}
