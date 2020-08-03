using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    [SerializeField]
    private GameObject PauseMenu;

    private bool PauseMenuActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("Escape"))
        {
            if (PauseMenuActive == false)
            {
                Paused();
            }
            else;
            {
                UnPause();
            }

        }





    }



    private void Paused()
    {

        PauseMenu.SetActive(true);
        PauseMenuActive = true;

    }


    private void UnPause()
    {
        
        PauseMenu.SetActive(false);
        PauseMenuActive = false;


    }




}
