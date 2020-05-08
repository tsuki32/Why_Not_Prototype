using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;

    public void FireBullet()
    {
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }



}
