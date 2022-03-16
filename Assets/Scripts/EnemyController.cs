using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform player;
    public Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diretion = player.position - transform.position;
        float angle = Mathf.Atan2(diretion.y, diretion.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        diretion.Normalize();
        movement = diretion;
    }
    private void FixedUpdate()
    {
        movecharacter(movement);
    }
    void movecharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * 2 * Time.deltaTime));
    }
}
