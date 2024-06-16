using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D _compRigidBody2D;
    public float speddY;
     public EnemyContainerControl  enemyContainer;
    private void Awake()
    {
        _compRigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _compRigidBody2D.velocity = new Vector2(0, -speddY);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "arrow")
        {
            Destroy(this.gameObject);
            enemyContainer.IncreasePoints(1);
        }
    }
    public void SetEnemyContainerControl(EnemyContainerControl enemyContainer )
    {
        this.enemyContainer = enemyContainer;
    }
}
