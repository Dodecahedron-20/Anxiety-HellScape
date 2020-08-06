using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    [SerializeField]
    private int delay;

    [SerializeField]
    private GameObject CloudsPrefab;

    [SerializeField]
    private int height;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(makeclouds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    private IEnumerator makeclouds()
    {

        yield return new WaitForSeconds(delay);
        Instantiate(CloudsPrefab, new Vector3(15, height, 0), Quaternion.identity);
        StartCoroutine(makeclouds());


    }




}
