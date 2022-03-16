using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float MovX = Input.GetAxisRaw("Horizontal");
        float MovY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(20 * MovX, rb.velocity.y);
        rb.velocity = new Vector2(20 * MovY, rb.velocity.x);
    }
}
