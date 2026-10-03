using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Renderer checkpointRenderer;

    private void Start()
    {
        checkpointRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerRespawn playerRespawn = other.GetComponent<PlayerRespawn>();
            if (playerRespawn != null)
            {
                playerRespawn.UpdateCheckpoint(transform.position);
                Debug.Log("Checkpoint aktywowany: " + transform.position);

                if (checkpointRenderer != null)
                {
                    checkpointRenderer.material.color = Color.green;
                }
            }
        }
    }
}
