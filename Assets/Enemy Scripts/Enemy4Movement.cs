using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public Vector3 direction;
    public Transform target;
    public float timer;
    public float maxTimer;
    public float radius;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {

        if (Vector3.Distance(transform.position, target.position) <= radius)
        {
            this.GetComponent<EnemyMovement>().enabled = false;
            Vector3 tempDirection = target.transform.position - transform.position;
            direction = tempDirection.normalized;
            rb.velocity = direction * speed;       
        }
        else
        {
            this.GetComponent<EnemyMovement>().enabled = true ;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
