using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    bool GameEnded = false;

    public Text timeText;
    public float currentTime = 0f;
    public float startingTime = 65f;

    public float ResetDelay = 0f;

    public GameObject completeLevel;
    public GameObject removeScore;

    public void CompleteLevel()
    {
        Debug.Log("Level Completed");
        completeLevel.SetActive(true);
        removeScore.SetActive(false);
    }

    public void EndGame()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", ResetDelay);
        }


    }
#needed some help from Brackeys above
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Restart");
    }

    void Start()
    {
        currentTime = startingTime;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        timeText.text = currentTime.ToString("0");
    

        if (currentTime <= 3)
        {
        timeText.color = Color.red;
         }

        if (currentTime <= 0)
        {
            Invoke("Restart", 0.1f);
            currentTime = startingTime;
        }
    }
}




