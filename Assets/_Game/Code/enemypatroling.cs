using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypatroling : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    public float speed;
    public float midPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        anim.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        Debug.Log("POSITION: " + point);
        if (currentPoint == pointB.transform)
        {

            rb.linearVelocity = new Vector2(speed, 0);
            Debug.Log("MOVING RIGHT");
        }
        else
        {
            rb.linearVelocity = new Vector2(-speed, 0);
            Debug.Log("MOVING LEFT");
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < midPoint && currentPoint == pointB.transform)
        {
            
            flip();
            currentPoint = pointA.transform;
            Debug.Log("FLIP A point" + currentPoint.position);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < midPoint && currentPoint == pointA.transform)
        {
            flip();
            currentPoint = pointB.transform;
             Debug.Log("FLIP B point" + currentPoint.position);
        }

    }

    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
    
}
