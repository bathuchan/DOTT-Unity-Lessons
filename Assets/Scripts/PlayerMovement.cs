using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f; // Zıplama kuvveti
    [SerializeField] private float horizontalSpeed = 2f; // Sağa/sola hareket hızı
    private Rigidbody rb;

    [SerializeField]
    private GameManager gm;

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
        rb.velocity = Vector3.zero; // Yükseklik hızını sıfırlıyoruz (0 , 0, 0)
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Yukarı doğru kuvvet uyguluyoruz
    }
    private void MoveHorizontal()
    {
        // Horizontal input değerini alıyoruz
        float horizontalInput = Input.GetAxis("Horizontal");

        // Sağa ve sola hareket
        rb.velocity = new Vector3(horizontalInput * horizontalSpeed, rb.velocity.y, rb.velocity.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        for(int i = 0;i < collision.contactCount; i++)
        {
            if(collision.GetContact(i).otherCollider.name == "Cube (1)" || collision.GetContact(i).otherCollider.name == "Cube (2)")
            {
                GameOver();
            }
        }
    }
    private void GameOver()
    {
        Debug.Log("Game Over!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PointGain")
        {
            PointGained(); 
        }
    }

    private void PointGained()
    {
        gm.point++;
    }
}
