using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Animator heroi;

    void Start()
    {
        heroi = GetComponent<Animator>();
    }

    void Update()
    {
        bool isMoving = false;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            isMoving = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
            isMoving = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
            isMoving = true;
        }

        heroi.SetBool("Correndo", isMoving);
        heroi.SetBool("Parado", !isMoving);
    }
}
