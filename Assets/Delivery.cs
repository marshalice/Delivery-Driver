using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("I've McFallen!");
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package"){
            Debug.Log("Package picked up");
        }

        if(other.tag == "Rebel"){
            Debug.Log("Delivered package.");
        }
    }
}
