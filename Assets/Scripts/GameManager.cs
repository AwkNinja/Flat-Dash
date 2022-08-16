using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;

    public GameObject completeLevelUI;
    public GameObject gameOverUI;

    public Text scoreText;
    private int score;
    private int time;

    public Text totalScore;
    public Text totalTime;


    void Start()
    {
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        if(gameOver == false)
        {
            gameOver = true;
            gameOverUI.SetActive(gameOver);     //displays the gameover UI
            Invoke("Restart", 2f);      //calls the restart function after 1 second
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);     //Reloads the level currently playing from the start
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);       //displays the level complete UI
        totalScore.text = "Total Score: " + score;
        time = FindObjectOfType<TimeScore>().time;
        totalTime.text = "Total Time: " + time.ToString();
    }

    public void IncrementScore(int num)
    {
        score += num;
        scoreText.text = "Score: " + score;
    }
}
