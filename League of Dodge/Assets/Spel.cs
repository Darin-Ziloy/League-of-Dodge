using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spel : MonoBehaviour
{
    public float speed = -10;

 
    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
}
