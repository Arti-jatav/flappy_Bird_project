
using UnityEngine;
using UnityEngine.SceneManagement;
 public class UIManager : MonoBehaviour
{
    public static UIManager Instance { set; get; }
    public GameObject gameOver;
    public GameObject puseMenu;
    private void Start()
    {
        Instance = this;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GameOver ()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }
    public void ResetGame ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void PuseGame()
    {
        Time.timeScale = 0;
        puseMenu.SetActive(true);
    }
    public void ResumGame()
    {
        Time.timeScale = 1;
        puseMenu.SetActive(false);
    }
}
