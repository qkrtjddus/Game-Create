using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float Movespeed = 3.0f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");    // A, D Ű�� �̵�
        float VerticalInput = Input.GetAxis("Vertical");       // W, S Ű�� �̵�
        Vector2 Movement = new Vector2(horizontalInput, VerticalInput) * Movespeed * Time.deltaTime;
        transform.Translate(Movement);      // ĳ���� �̵�
    }
}
