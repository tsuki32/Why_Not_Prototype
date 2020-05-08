using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    private AudioSource Audio;
    public AudioClip fire;

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
