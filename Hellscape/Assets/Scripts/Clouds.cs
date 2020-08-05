using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{


    [SerializeField]
    private float Movespeed;
    [SerializeField]
    private Vector2 userDirection = Vector2.left;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(userDirection * Movespeed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }







}
