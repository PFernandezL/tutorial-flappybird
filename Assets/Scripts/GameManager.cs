using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject quitButton;

    public Player player;

    public Text gameOverCountdown;
    public float countTimer = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");    
        gameOverCountdown.gameObject.SetActive(false);
        quitButton.SetActive(true);
        Time.timeScale = 0;
    }

    private void Update()
    {
        if( player.isDead )
        {
            gameOverCountdown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
        }

        gameOverCountdown.text = "Restarting in " + countTimer.ToString("0");

        if(countTimer < 0)
        {
            RestartGame();
        }
    }

    public void StartGame()
    {
        Debug.Log("Start Game");
        startButton.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
    }


    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void Salir(){
        Application.Quit();
    }
}
