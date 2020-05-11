using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Bullet Settings")]

    [Tooltip("Define the speed of the bullet prefab")]
    public float speed = 20f;

    [Tooltip("Add bullets rigidbody2D")]
    public Rigidbody2D rb;

    [Header("Effect for bullet impact")]
    [Tooltip("Spawns an effect on impact of enemy")]
    public GameObject impactEffect;
    

    // Start is called before the first frame update
    void Start()
    {
        
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D Collider) 
    {
        if (Collider.gameObject.tag == "Enemy")
        {
            Destroy(Collider.transform.gameObject);
            Debug.Log("ENEMY WAS DETECTED");

            Instantiate(impactEffect, transform.position, transform.rotation);
            
        }

        Destroy(GameObject.FindWithTag("Bullet"), 5);

    }


}
