using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
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
