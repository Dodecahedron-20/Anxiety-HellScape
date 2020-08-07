using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTracking : MonoBehaviour
{


   

    private Vector3 baseposition;

    [SerializeField]
    private float EyeSize;

    // Start is called before the first frame update
    void Start()
    {
        baseposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);


        var direction = (mousePos) - (baseposition);
        var target = direction.normalized * EyeSize;
        transform.position = target + baseposition;



    }
}
