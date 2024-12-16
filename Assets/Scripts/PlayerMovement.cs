using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f; // Zıplama kuvveti
    [SerializeField] private float horizontalSpeed = 2f; // Sağa/sola hareket hızı
    private Rigidbody rb;

    [SerializeField]
    private GameManager gm;

    private Animator anim;
    //private ParticleSystem part;
    void Start()
    {
        Time.timeScale = 1f;
        // Rigidbody bileşenini alıyoruz
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
       // part= GetComponentInChildren<ParticleSystem>();
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
        anim.SetTrigger("PlayJump");
        //anim.SetTrigger("JumpTrigger");
        //part.Play();
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
        if(collision.gameObject.tag == "Obstacle") 
        {
            GameOver();
        }
       
    }
    private void GameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0.1f;
        StartCoroutine(ReloadScene(0.1f));
    }

    private IEnumerator ReloadScene(float timeToWait) 
    {
        Debug.Log("Scene will reset in "+timeToWait);

        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene("SampleScene");
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
