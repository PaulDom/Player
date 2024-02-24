using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoins : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, 0.3f); //непрерывное вращение
        //transform.rotation = Quaternion.Euler(0, 45, 0);  //резкий поворот.
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 45, 0), Time.deltaTime); //плавный поворот

    }
}