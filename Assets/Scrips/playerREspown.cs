using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 respawnPoint;
    private Rigidbody rb;

    [SerializeField]
    private float fallThreshold = -10f;

    [Header("Audio")]
    public AudioSource respawnSource; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        respawnPoint = transform.position;
    }

    private void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            Respawn();
        }
    }

    public void UpdateCheckpoint(Vector3 newCheckpoint)
    {
        respawnPoint = newCheckpoint;
        Debug.Log("Nowy punkt odrodzenia: " + respawnPoint);
    }

    public void Respawn()
    {
        transform.position = respawnPoint;
        transform.rotation = Quaternion.identity;

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        if (respawnSource != null)
        {
            respawnSource.Play();
        }

        Debug.Log("Gracz odrodzony w punkcie: " + respawnPoint);
    }
}
