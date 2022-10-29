using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyMovement : MonoBehaviour
{
    public AIPath aiPath;
    Vector2 direction;
    public Animator animator;
    private float distance;
    public GameObject player;
    private float lockPos = 0;
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
        faceVelocity();
    }
    void faceVelocity()
    {
        direction = aiPath.desiredVelocity;
        transform.right = direction;
    }
}
