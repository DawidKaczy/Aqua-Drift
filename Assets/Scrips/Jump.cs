using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public float jumpForce = 7f;        
    public float forwardBoost = 2f;   
    public AudioSource jumpSound;       

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {

                Vector3 boostDirection = (other.transform.forward * forwardBoost) + (Vector3.up * jumpForce);
                rb.linearVelocity = boostDirection;
            }

            if (jumpSound != null)
            {
                jumpSound.Play();
            }
        }
    }
}
