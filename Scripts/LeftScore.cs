using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeftScore : MonoBehaviour
{

    public Text scoreText;
    public GameObject ball;
    GameObject ballDestroyer;

    public int scoreCounter;

    private void Start()
    {
        GameObject _ = Instantiate(ball);
    }


    void ScoreCounter()
    {

        scoreCounter += 1;
        GameObject _ = Instantiate(ball);

        if (scoreCounter > 9)
        {
            scoreCounter = 0;
            RestartGame();
        }
        scoreText.text = scoreCounter.ToString();
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Ball")
        {
            ScoreCounter();
            ballDestroyer = GameObject.FindGameObjectWithTag("Ball");
            Destroy(ballDestroyer);
        }

    }

    void RestartGame()
    {

        SceneManager.LoadScene("Menu");

    }

}

