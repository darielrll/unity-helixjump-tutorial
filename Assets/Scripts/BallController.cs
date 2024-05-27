using UnityEngine;
using UnityEngine.Audio;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    public float impulseForce = 3f;

    private bool ignoreNextCollision;
    private Vector3 startPosition;

    [HideInInspector]
    public int perfectPass;
    public float superSpeed = 8;
    private bool isSuperSpeedActive;
    public int perfectPassCount = 1;
    public GameObject splash;
    public AudioSource collisionAudio;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionAudio.Play();
        AddSplash(collision);

        if(ignoreNextCollision)
        {
            return;
        }

        if (isSuperSpeedActive  &&  !collision.transform.GetComponent<GoalController>())
        {
            Destroy(collision.transform.parent.gameObject, 0.2f);
        }
        else
        {
            DeathPart deathPart = collision.transform.GetComponent<DeathPart>();
            if (deathPart)
            {
                GameManager.gameManager.RestartLevel();
            }
        }

        rb.linearVelocity = Vector3.zero;
        rb.AddForce(Vector3.up * impulseForce, ForceMode.Impulse);
        ignoreNextCollision = true;
        Invoke("AllowNextCollision", 0.2f);

        perfectPass = 0;
        isSuperSpeedActive = false;
    }

    private void Update()
    {
        if (perfectPass >= perfectPassCount  &&  !isSuperSpeedActive)
        {
            isSuperSpeedActive = true;

            rb.AddForce(Vector3.down * superSpeed, ForceMode.Impulse);
        }
    }

    private void AllowNextCollision()
    {
        ignoreNextCollision = false;
    }

    public void ResetBall()
    {
        transform.position = startPosition;
    }

    public void AddSplash(Collision collision)
    {
        GameObject newSplash = Instantiate(splash);

        newSplash.transform.SetParent(collision.transform);
        newSplash.transform.position = new Vector3(transform.position.x, transform.position.y - 0.11f, transform.position.z);
        Destroy(newSplash, 3);
    }
}
