using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class End : MonoBehaviour
{
    public GameObject sButton, results;
    public Text treasures, coinsRes, score;
    public heroscript Health;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && sButton.activeInHierarchy)
        {
            results.SetActive(true);
            Time.timeScale = 0f;
            int scoreVal = CalculateScore();

            coinsRes.text = "COLLECTED COINS: " + treasures.text;
            score.text = "SCORE: " + scoreVal;

            if (SceneManager.GetActiveScene().buildIndex == 1 && PlayerPrefs.GetInt("Score1") < scoreVal)
            {
                PlayerPrefs.SetInt("Score1", scoreVal);
            }
            else if (PlayerPrefs.GetInt("Score2") < scoreVal)
            {
                PlayerPrefs.SetInt("Score2", scoreVal);
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sButton.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sButton.SetActive(false);
    }
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        results.SetActive(false);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private int CalculateScore()
    {
        return (Convert.ToInt32(treasures.text) * 100) + (Convert.ToInt32(Health) * 5);
    }
}
