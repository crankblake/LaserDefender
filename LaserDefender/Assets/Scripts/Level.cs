using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    public void LoadGameScene()
    {
        FindObjectOfType<GameSession>().ResetScore();
        SceneManager.LoadScene("Game");
    }
    public void LoadStartMenu()
    {
        FindObjectOfType<GameSession>().ResetScore();
        SceneManager.LoadScene("StartMenu");
    }
    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("GameOver");
    }
}
