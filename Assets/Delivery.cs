using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1f;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("I've McFallen!");
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, delay);
        }

        if(other.tag == "Rebel" && hasPackage){
            Debug.Log("Delivered package.");
            hasPackage = false;
        }
    }
}
