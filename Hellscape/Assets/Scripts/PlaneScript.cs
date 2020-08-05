using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{

    public float speed = 1f;
    public float rotation = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 pos = transform.position;
            pos.y += speed * Time.deltaTime;
            transform.Rotate(new Vector3(0, 0, rotation));
            transform.position = pos;

         if ( transform.rotation.z > 0)
            {
                Debug.Log("the plane is saved");
            }
     
        }
        
       
        
    }
}
