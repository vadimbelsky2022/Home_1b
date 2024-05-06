using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
    public bool teleport;
    public int teleport_frequency;
    public System.DateTime startTime;
    public System.TimeSpan interval;

    // Start is called before the first frame update
    void Start()
    {
        teleport = false;
        teleport_frequency = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (!teleport)
        {
            startTime = SetStartTime();
            teleport = true;
        }

        System.DateTime currentTime = System.DateTime.Now;
        interval = currentTime - startTime;
        if (interval.TotalSeconds >= teleport_frequency)
        {
            Go();
            teleport = false;
        }
    }

    void Go()
    {
        transform.position = new Vector3(Random.Range(-12.0f, 12.0f),
            1.0f, Random.Range(-12.0f, 12.0f));
    }

    System.DateTime SetStartTime()
    {
        System.DateTime time = System.DateTime.Now;
        return time;
    }
}
