using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowmovement : MonoBehaviour
{
    public int velocidadY;
    public float vertical;
    private Rigidbody2D movimiento;
    public GameObject Explotion;

    private void Awake()
    {
        movimiento = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        movimiento.velocity = new Vector2(0, velocidadY * vertical);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Instantiate(Explotion, transform.position, transform.rotation);
        }

    }
}
