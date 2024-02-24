using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private float speed = 5f;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;     
    }

    void Start()
    {
        Destroy(gameObject, 3);
    }
}
