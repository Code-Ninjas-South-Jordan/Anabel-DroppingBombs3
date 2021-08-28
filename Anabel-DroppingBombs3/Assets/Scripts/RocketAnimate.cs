using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAnimate : MonoBehaviour
{
    //This script is for animating the rocket.
    [Header("Animator")]
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("HAxis", horizontal);
    }
}
