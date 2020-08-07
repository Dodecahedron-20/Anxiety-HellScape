using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMove : MonoBehaviour
{
    public float speed = 1f;


    [SerializeField]
    private int NextLevel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Arrow")
        {
            SceneManager.LoadScene(NextLevel);
        }
    }




}
