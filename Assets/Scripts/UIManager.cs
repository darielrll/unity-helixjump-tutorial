using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text currentScoreText;
    public Text bestScoreText;


    void Update()
    {
        currentScoreText.text = "Score: " + GameManager.gameManager.currentScore;
        bestScoreText.text = "Best: " + GameManager.gameManager.bestScore;
    }
}
