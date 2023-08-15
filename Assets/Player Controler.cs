using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Vector2 Inputvec;
    public float speed;
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Inputvec.x = Input.GetAxisRaw("Horizontal");    // A, D 키로 이동
        Inputvec.y = Input.GetAxisRaw("Vertical");       // W, S 키로 이동
        
    }
    private void FixedUpdate()
    {
        Vector2 nextvec = Inputvec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextvec);
    }
}