using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float Movespeed = 3.0f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");    // A, D 키로 이동
        float VerticalInput = Input.GetAxis("Vertical");       // W, S 키로 이동
        Vector2 Movement = new Vector2(horizontalInput, VerticalInput) * Movespeed * Time.deltaTime;
        transform.Translate(Movement);      // 캐릭터 이동
    }
}
