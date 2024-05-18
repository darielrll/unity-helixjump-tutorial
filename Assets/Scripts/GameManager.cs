using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int bestScore;
    public int currentScore;
    public int currentLevel = 0;

    public static GameManager gameManager;

    void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
        }
        else if (gameManager != this)
        {
            Destroy(gameObject);
        }
    }

    public void NextLevel()
    {

    }

    public void RestartLevel()
    {

    }

    public void AddScore(int scoreToAdd)
    {
        currentLevel += scoreToAdd;

        if(currentScore > bestScore)
        {
            bestScore = currentScore;
        }
    }
}
