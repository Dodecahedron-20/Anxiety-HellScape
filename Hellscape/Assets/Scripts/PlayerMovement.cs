using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField]
    private KeyCode LeftButton;
    [SerializeField]
    private KeyCode RightButton;

    [SerializeField]
    private KeyCode UpButton;
    [SerializeField]
    private KeyCode DownButton;

    [SerializeField]
    private bool VerticalAccess;

    //all speed things. Speed is current, Additonal is to add and Start is the beginning
    private float Speed;
    [SerializeField]
    private float StartSpeed;
    [SerializeField]
    private float AditionalSpeed;


    [SerializeField]
    private Text SpeedText;

    // Start is called before the first frame update
    void Start()
    {
        Speed = StartSpeed;
        SpeedText.text = " " + Speed;
    }

    // Update is called once per frame
    void Update()
    {

        var horiz = 0;
        var vert = 0;

        if (Input.GetKey(LeftButton))
        {
            horiz -= 1;
        }

        if (Input.GetKey(RightButton))
        {
            horiz += 1;
        }


        if (VerticalAccess == true)
        {
            if (Input.GetKey(UpButton))
            {
                vert += 1;
            }

            if (Input.GetKey(DownButton))
            {
                vert -= 1;
            }


        }

        var movement = new Vector3(horiz, vert, 0).normalized * Speed * Time.deltaTime;
        transform.position += movement;
       


    }

    public void AddingSpeed()
    {
        SpeedUp();
        SpeedText.text = " " + Speed;
    }

    private float SpeedUp()
    {
        Speed = Speed + AditionalSpeed;

        return Speed;

    }







}
