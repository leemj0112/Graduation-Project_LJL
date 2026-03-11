using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rd;

    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        //이동 코드(자율 이동)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 rawInput = new Vector2(horizontal, vertical);

        if (rawInput.sqrMagnitude > 1f) //순수입력값이 1 초과하면
        {
            rawInput = rawInput.normalized; //순수입력값을 정규화
        }

        rd.velocity = rawInput * moveSpeed; //velocity에 순수입력값*이동속도 대입
    }
}
