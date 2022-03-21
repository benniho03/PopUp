using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1;
    public Collider2D otherCollider;
    ForceMode2D m_ForceMode;
    Vector2 m_NewForce;
    Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        m_NewForce = new Vector2(0, 12.0f);
        rb.AddForce(m_NewForce, ForceMode2D.Impulse);
    }
}