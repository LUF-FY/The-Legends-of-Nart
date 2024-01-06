using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Hero : MonoBehaviour
{

    [SerializeField] private float _moveSpeed;

    private Rigidbody rb;
    public Animator animator;
    private Vector3 _direction;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Debug.Log(_direction.x);

        if (rb != null)
        {
            rb.velocity = _direction * Time.deltaTime * _moveSpeed;
        }

        if (_direction.x > 0.001f)
        {
            animator.SetBool("right", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Mathf.Abs(_direction.x) < 0.001f) 
        {
            animator.SetBool("right", false);
        }
        else
        {
            animator.SetBool("right", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (_direction.z > 0.001f)
        {
            animator.SetBool("foreward", true);
            animator.SetBool("backward", false);
        }
        else if (_direction.z < -0.001f)
        {
            animator.SetBool("foreward", false);
            animator.SetBool("backward", true);
        }
        else
        {
            animator.SetBool("foreward", false);
            animator.SetBool("backward", false);
        }

    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}
