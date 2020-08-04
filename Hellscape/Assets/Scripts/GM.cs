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
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenuActive)
            {
                UnPause();
            }
            else
            {
                Paused();
                
            }

        }

    }


    //pause the game
    private void Paused()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        PauseMenuActive = true;

    }


    public void UnPauseButton()
    {
        UnPause();
    }

    private void UnPause()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        PauseMenuActive = false;


    }




}
