using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    
    private Vector3 pos1;
    private Vector3 pos2;

    [Header("Enemy movement")]

    [Tooltip("Define what direction and how far you want the enemy to move")]
    public Vector3 posDiff = new Vector3(0f, 0f, 20f);

    [Tooltip("Rate the speed you want the enemy to move at")]
    public float speed = 1.0f;

    void Start()
    {
        pos1 = transform.position;
        pos2 = transform.position + posDiff;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
       // transform.Rotate(Vector3.up * 10f * Time.deltaTime);
    }

    //This did not work

    //public float speed = 5;
    //public float distance;
    //public Transform groundDetection;

    //private bool movingRight = true;


    //void Update()
    //{
    //    transform.Translate(Vector2.right * speed * Time.deltaTime);
    //    RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
    //    if(groundInfo.collider == false)
    //    {
    //        if(movingRight == true)
    //        {
    //            transform.eulerAngles = new Vector3(0, -180, 0);
    //        }
    //        else
    //        {
    //            transform.eulerAngles = new Vector3(0, 0, 0);
    //            movingRight = true;

    //        }
    //    }
    //}
}
