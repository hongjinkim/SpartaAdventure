using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Player"))
        { 
            Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddForce(Vector2.up * 300, ForceMode.Impulse);
            }
        }
    }
}
