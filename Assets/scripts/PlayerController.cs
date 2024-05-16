using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private Rigidbody rd;
    private float movX;
    private float movY;
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movmentValue)
    {
        Vector2 movmetVector = movmentValue.Get<Vector2>();

        movX = movmetVector.x;
        movY = movmetVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movment = new Vector3(movX, 0f, movY);
        rd.AddForce(movment);   
    }

  


}
