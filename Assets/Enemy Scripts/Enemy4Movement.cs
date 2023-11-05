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
    }

    void Update()
    {
        Move();
        if (Vector3.Distance(transform.position, target.position) >= radius)
        {
            this.GetComponent<Enemy2Movement>().enabled = true;
        }
    }

    void Move()
    {
        if (Vector3.Distance(transform.position, target.position) <= radius)
        {
            this.GetComponent<EnemyMovement>().enabled = false;
            Vector3 tempDirection = target.position - transform.position;
            direction = tempDirection.normalized;
            rb.velocity = direction * speed;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
