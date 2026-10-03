using UnityEngine;

public class BoostTrigger : MonoBehaviour
{
    public float forwardBoost = 14f;
    public AudioSource boostSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            KayakMovement movement = other.GetComponent<KayakMovement>();

            if (movement != null)
            {
                movement.AddBoost(forwardBoost);
            }

            if (boostSound != null)
                boostSound.Play();
        }
    }
}