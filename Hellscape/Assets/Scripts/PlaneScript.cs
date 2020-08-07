using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneScript : MonoBehaviour
{

    public float speed = 1f;
    public float rotation = 1f;

    [SerializeField]
    private int NextLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 pos = transform.position;
            pos.y += speed * Time.deltaTime;
            transform.Rotate(new Vector3(0, 0, rotation));
            transform.position = pos;

         if ( transform.rotation.z > 0)
            {
                SceneManager.LoadScene(NextLevel);
            }
     
        }
        
       
        
    }
}
