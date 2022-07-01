using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverMenu, player;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (player == null)
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameOverMenu.SetActive(false);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
