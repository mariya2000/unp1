using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bonusskript : MonoBehaviour
{
    int c = 0;
    int dist = 10;
    float speed = 0.005f;

    void FixedUpdate ()
    {
        c++;
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y + speed,
            transform.position.z);
        if (c > dist)
        {
            speed *= -1;
            c = 0;
        }
       
    }

} 