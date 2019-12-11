using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shere;
    public List<Vector3> data;
    public int countSheres=1;
    void Start()
    {
         for (int i = 0; i < countSheres; i++) {
         
Instantiate(shere,new Vector3 (Random.Range(-210,210), 8, Random.Range(-200,200)), Quaternion.identity);
    }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
