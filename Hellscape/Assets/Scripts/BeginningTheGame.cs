using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginningTheGame : MonoBehaviour
{

    [SerializeField]
    private KeyCode StartGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(StartGame))
        {
            SceneManager.LoadScene(1);
        }
    }
}
