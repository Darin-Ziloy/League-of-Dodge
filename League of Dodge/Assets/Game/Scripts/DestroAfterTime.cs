using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroAfterTime : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Spell")
        {
            Destroy(other.gameObject);
        }
    }
}

