using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int velocidadX;
    public float horizontal;
    public int velocidadY;
    public float vertical;
    private Rigidbody2D movimiento;
    public GameObject bulletPrefab;
    private void Awake()
    {
        movimiento = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
   
    void Start()
    {
        movimiento.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if(Input.GetButtonDown("Fire1") == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
    private void FixedUpdate()
    {
        movimiento.velocity = new Vector2(velocidadX * horizontal, velocidadY * vertical);
    }
}
