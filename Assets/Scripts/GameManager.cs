using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public Player player;

    public Text gameOverCountdown;
    public float countTimer = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");    
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 0;
        
        startButton.SetActive(true);
        //Time.timeScale = 1;
    }

    private void Update()
    {
        if( player.isDead )
        {
            gameOverCountdown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
            Debug.Log("Counter: " + countTimer.ToString("0"));
        }

        gameOverCountdown.text = "Restarting in " + countTimer.ToString("0");

        if(countTimer < 0)
        {
            RestartGame();
        }
    }

    public void StartGame()
    {
        Debug.Log("StartGame");
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        Time.timeScale = 0;
    }


    public void RestartGame()
    {
        Debug.Log("RestartGame");
        EditorSceneManager.LoadScene(0);
    }
}
