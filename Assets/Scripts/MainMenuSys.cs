using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSys : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("StartCutScene");
    }
    public void quit()
    {
        Application.Quit();
    }
    public void inMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
