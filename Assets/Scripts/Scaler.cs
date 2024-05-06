using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localScale.x < 4.0f)
        {
            this.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
        }
        
    }
}
