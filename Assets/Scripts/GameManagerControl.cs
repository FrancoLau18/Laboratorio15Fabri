using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManagerControl : MonoBehaviour
{
    public Text texPoints;
    public int points;
     public string sceneToLoad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
    private void Start()
    {
        IncreasePoints(0);
    }
    public void IncreasePoints (int pointsToAdd)
    {
        points = points + pointsToAdd;
        texPoints.text = "Puntos: " + points;
    }
}
