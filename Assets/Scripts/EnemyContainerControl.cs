using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minXPosition;
    public float maxXPosition;
    public float yPosition;
    public GameManagerControl gameManager;
    void Start()
    {
        CreateEnemy();
    }
    void CreateEnemy()
    {
        float xPosition = Random.Range(minXPosition, maxXPosition );
        Vector2 positionToCreate = new Vector2(xPosition, yPosition);
        GameObject enemy = Instantiate(prefabEnemy, positionToCreate, transform.rotation);
        enemy.GetComponent<Enemy>().SetEnemyContainerControl(this);
        Invoke("CreateEnemy", 2);
    }
    public void IncreasePoints(int pointsToAdd)
    {
        gameManager.IncreasePoints(pointsToAdd);
    }
}
