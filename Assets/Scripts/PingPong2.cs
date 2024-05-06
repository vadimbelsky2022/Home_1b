using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong2 : MonoBehaviour
{
    public Vector3 startPoint;
    public Vector3 finishPoint;
    public Vector3 direction;
    public Vector3 temp;
    public float speed;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = new Vector3(Random.Range(-12.0f, 12.0f),
            1.0f, Random.Range(-12.0f, 12.0f));
        finishPoint = new Vector3(Random.Range(-12.0f, 12.0f),
            1.0f, Random.Range(-12.0f, 12.0f));

        transform.position = startPoint;
        speed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        direction = finishPoint - startPoint;
        transform.Translate(direction * speed * Time.deltaTime);

        distance = (transform.position.x - finishPoint.x) *
            (transform.position.x - finishPoint.x) +
            (transform.position.y - finishPoint.y) *
            (transform.position.y - finishPoint.y) +
            (transform.position.z - finishPoint.z) *
            (transform.position.z - finishPoint.z);

        if(distance < 10)
        {
            temp = startPoint;
            startPoint = finishPoint;
            finishPoint = temp;
        }

    }
}
