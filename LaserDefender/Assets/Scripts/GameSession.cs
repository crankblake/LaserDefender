using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    //config params
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerEnemyDestroyed= 50;
    [SerializeField] TextMeshProUGUI scoreText;
    //[SerializeField] bool isAutoPlayEnabled;
    //state variables
    [SerializeField] int currentScore = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            scoreText.text = currentScore.ToString();
        }
    }

    private void Start()
    {
        // scoreText.text = currentScore.ToString();
        //string SceneName = FindObjectOfType < Level >

      // if ()
    }
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }
    
    public void AddToScore(int scoreValue)
    {
        currentScore += scoreValue;
        //currentScore += pointsPerEnemyDestroyed;
        //scoreText.text = currentScore.ToString();
    }
    public void ResetScore()
    {
        Destroy(gameObject);
    }
    public int GetScore()
    {
        return currentScore;
    }
    
    /*public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }*/
}
