using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [Header("Respawn settings")]

    [Tooltip("Add the player")]
    [SerializeField] private Transform Player;

    [Tooltip("Add the position you want to respawn too, defined with an empty gameobject")]
    [SerializeField] private Transform respawnPoint;


    void OnTriggerEnter2D(Collider2D other)
    {
        Player.transform.position = respawnPoint.transform.position;
    }
 
}
