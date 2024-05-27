using UnityEngine;

public class PassScorePoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.gameManager.AddScore(1);
        FindObjectOfType<BallController>().perfectPass++;
    }
}
