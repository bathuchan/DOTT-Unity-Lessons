using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f; // Zıplama kuvveti
    [SerializeField] private float horizontalSpeed = 2f; // Sağa/sola hareket hızı
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody bileşenini alıyoruz
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Eğer Space tuşuna basıldıysa
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        // Sağa veya sola hareket kontrolü
        MoveHorizontal();
    }

    private void Jump()
    {
        // Önce dikey hızını sıfırla, sonra yukarı doğru kuvvet uygula
        rb.velocity = Vector3.zero; // Yükseklik hızını sıfırlıyoruz
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Yukarı doğru kuvvet uyguluyoruz
    }
    private void MoveHorizontal()
    {
        // Horizontal input değerini alıyoruz
        float horizontalInput = Input.GetAxis("Horizontal");

        // Sağa ve sola hareket
        rb.velocity = new Vector3(horizontalInput * horizontalSpeed, rb.velocity.y, rb.velocity.z);
    }
}
