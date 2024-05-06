using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public int dir;

    // Start is called before the first frame update
    void Start()
    {
        dir = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(dir == 1)
        {
            if (transform.position.x < 5.0)
            {
                transform.position += new Vector3(4.0f, 0, 0) * Time.deltaTime;
            }
            else dir = -1;
        }
        if (dir == -1)
        {
            if (transform.position.x > -5.0)
            {
                transform.position += new Vector3(-4.0f, 0, 0) * Time.deltaTime;
            }
            else dir = 1;
        }

    }
}
