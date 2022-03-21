using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    ForceMode2D m_ForceMode;
    Vector2 m_NewForce;
    Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if(Input.GetButtonDown("Jump")){
            m_NewForce = new Vector2(0, 10.0f);
            rb.AddForce(m_NewForce, ForceMode2D.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.A)){
            m_NewForce = new Vector2(-3.0f, 0);
            rb.AddForce(m_NewForce, ForceMode2D.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.D)){
            m_NewForce = new Vector2(3.0f, 0);
            rb.AddForce(m_NewForce, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
            m_NewForce = new Vector2(0, 5.0f);
            rb.AddForce(m_NewForce, ForceMode2D.Impulse);
    }
}