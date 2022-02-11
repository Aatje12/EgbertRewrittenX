using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator myAnim;
    private Transform target;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float range;
    void Start()
    {
        myAnim = GetComponent<Animator>();
        target = FindObjectOfType<BasicMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        myAnim.SetBool("isMoving", true);
        myAnim.SetFloat("moveX", (target.position.x - transform.position.x));
        myAnim.SetFloat("moveY", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

}
