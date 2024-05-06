using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if (i < 500)
        {
            return;
        }
        else
        {
            transform.position = new Vector3(Random.Range(-12.0f, 12.0f),
            1.0f, Random.Range(-12.0f, 12.0f));
            i = 0;
        }
        
        
    }
}
