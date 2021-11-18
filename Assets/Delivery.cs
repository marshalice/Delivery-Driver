using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    bool hasPackage;
    [SerializeField] float delay = 1f;
    
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, delay);
        }

        if(other.tag == "Rebel" && hasPackage){
            Debug.Log("Delivered package.");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
