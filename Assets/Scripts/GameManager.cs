using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public Text scoreText;
    public GameObject winPanel;
    public int totalPickups = 5;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void UpdateScore(int currentScore)
    {
        scoreText.text = "Score: " + currentScore.ToString();
        
        if (currentScore >= totalPickups)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        winPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
