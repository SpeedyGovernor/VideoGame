using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene("Easy");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instruct");
    }

    public void MainScreen ()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
