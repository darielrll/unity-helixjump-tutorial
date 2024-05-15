using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float impulseForce = 3f;

    private bool ignoreNextCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if(ignoreNextCollision)
        {
            return;
        }

        rigidbody.linearVelocity = Vector3.zero;
        rigidbody.AddForce(Vector3.up * impulseForce, ForceMode.Impulse);
        ignoreNextCollision = true;
        Invoke("AllowNextCollision", 0.2f);
    }

    private void AllowNextCollision()
    {
       ignoreNextCollision = false;
    }
}
