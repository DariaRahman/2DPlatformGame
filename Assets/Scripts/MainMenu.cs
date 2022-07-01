using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu, levels;
    public Slider slider;

    static bool openLevels = false;
    private void Start()
    {
        Time.timeScale = 1f;
        if (openLevels)
        {
            levels.SetActive(true);
        }
        else 
        {
            mainMenu.SetActive(true);
        }

    }
    public void Quit()
    {
        Application.Quit();
    }

    public void SetMusicVolume(float vol)
    {
    }

    public void PlayLevel(int levelNum)
    {
        openLevels = true;
        switch (levelNum)
        {
            case 1:
                SceneManager.LoadScene("Level 1");
                break;
            case 2:
                SceneManager.LoadScene("Level 2");
                break;
            case 3:
                SceneManager.LoadScene("Level 3");
                break;
        }
    }
}
