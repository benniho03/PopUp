using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D otherCollider;
    Rigidbody2D rb;
    Vector2 m_NewForce;
    void Start()
    {
        rb = otherCollider.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        m_NewForce = new Vector2(2f, 0);
        rb.AddForce(m_NewForce, ForceMode2D.Impulse);
    }
}
