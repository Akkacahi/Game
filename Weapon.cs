using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float speed = 0.7f;
    public float delay = 1f;
    public float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += speed * this.gameObject.transform.forward;
        if (Time.time-startTime>=delay)
        {
            Destroy(gameObject);
        }
    }
}
