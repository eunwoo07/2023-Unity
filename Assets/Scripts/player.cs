using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpForce = 5.0f; // ���� ���� ������ ����

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D ������Ʈ ��������
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // �����̽� �ٸ� ������ ��
        {
            Jump(); // Jump �Լ� ȣ��
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // ���� ���� ����
    }
}