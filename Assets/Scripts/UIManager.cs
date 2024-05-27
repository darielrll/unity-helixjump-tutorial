using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text currentScoreText;
    public Text bestScoreText;


    public Slider slider;
    public Text actualLevel;
    public Text nextLevel;
    public Transform topTransform;
    public Transform goalTransform;
    public Transform ball;

    void Update()
    {
        currentScoreText.text = "Score: " + GameManager.gameManager.currentScore;
        bestScoreText.text = "Best: " + GameManager.gameManager.bestScore;

        ChangeSliderLevelAndProgress();
    }

    public void ChangeSliderLevelAndProgress()
    {
        actualLevel.text = "" + (GameManager.gameManager.currentLevel + 1);
        nextLevel.text = "" + (GameManager.gameManager.currentLevel + 2);

        float totalDistance = topTransform.position.y - goalTransform.position.y;
        float distanceLeft = totalDistance - (ball.position.y - goalTransform.position.y);

        float value = distanceLeft / totalDistance;
        slider.value = Mathf.Lerp(slider.value, value, 5);
    }
}
