using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTracker : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    private Vector3 baseposition;
    // Start is called before the first frame update
    void Start()
    {
        baseposition = transform.position; 
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get vector from zero to player then normalize then mutiply by radius set position to that

       var direction = (Player.transform.position) - (baseposition);
       var target =  direction.normalized * 0.16f;
       transform.position = target + baseposition;
       
    }
}
