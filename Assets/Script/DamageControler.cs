using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageControler : MonoBehaviour
{
    [SerializeField] private float doDamage = 10;
    [SerializeField] private HealthControler healthControler;
  

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
            Debug.Log("I WAS EATEN!!");

        }
    }

    void Damage()
    {
        healthControler.playerHealth = healthControler.playerHealth - doDamage;
        healthControler.UpdateHealth();
        this.gameObject.SetActive(false);
        Debug.Log("DAMAGED BY 10");
     
    }

}
