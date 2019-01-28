using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    //config params
    //[SerializeField] int pointsPerBlockDestroyed = 83;
    //[SerializeField] TextMeshProUGUI scoreText;
    //[SerializeField] bool isAutoPlayEnabled;
    //state variables
    //[SerializeField] int currentScore = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int gameStatusCount = FindObjectsOfType<MusicPlayer>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            //scoreText.text = currentScore.ToString();
        }
    }

    private void Start()
    {
        //scoreText.text = currentScore.ToString();
    }
    // Update is called once per frame
    /*
    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
    public void ResetScore()
    {
        Destroy(gameObject);
    }
    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }*/
}
