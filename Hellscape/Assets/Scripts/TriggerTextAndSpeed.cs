using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTextAndSpeed : MonoBehaviour
{

    [SerializeField]
    private GameObject RunningText;

    private bool encountered = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (encountered == false)
        {
            encountered = true;
            RunningText.SetActive(true);
            PlayerMovement.FindObjectOfType<PlayerMovement>().AddingSpeed();
        }
       

    }




}
