using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    public Text Level1Score, Level2Score, Level3Score;
    public int score1 = 0, score2 = 0, score3 = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("Score1"))
        {
            Level1Score.text = "BEST SCORE: " + PlayerPrefs.GetInt("Score1");
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.HasKey("Score2"))
        {
            Level2Score.text = "BEST SCORE: " + PlayerPrefs.GetInt("Score2");
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.HasKey("Score3"))
        {
            Level3Score.text = "BEST SCORE: " + PlayerPrefs.GetInt("Score3");
            PlayerPrefs.Save();
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("Score1");
        PlayerPrefs.DeleteKey("Score2");
        PlayerPrefs.DeleteKey("Score3");
        Level1Score.text = "BEST SCORE: ";
        Level2Score.text = "BEST SCORE: ";
        Level3Score.text = "BEST SCORE: ";
    
    }
}