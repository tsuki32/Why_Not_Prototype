using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [Header("Instantiate bullet settings")]

    [Tooltip("From what point do you want to fire your bullet from, define this with an empty gameobject attached to the player as a child")]
    public Transform FirePoint;

    [Tooltip("The bullet prefab")]
    public GameObject bulletPrefab;

    [Header("Audio settings")]
    [Tooltip("The audio you want to play when instantiating a bullet")]
    public AudioClip fire;
    private AudioSource Audio;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    public void FireBullet()
    {
        
        Audio.PlayOneShot(fire);
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }



}
