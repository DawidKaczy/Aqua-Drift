using UnityEngine;

public class SpikesControllerv2 : MonoBehaviour
{
    public float moveDistance = 5f;   
    public float speed = 2f;         
    public float cycleTime = 2f;      
    public float startDelay = 0f;    

    private bool isHidden = false;    
    private Vector3 startPosition;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Brak Rigidbody na " + gameObject.name);
            enabled = false;
            return;
        }

        rb.isKinematic = true;
        startPosition = transform.position;

        InvokeRepeating(nameof(Toggle), startDelay, cycleTime * 2);
    }

    void FixedUpdate()
    {
        Vector3 target = isHidden
            ? startPosition - Vector3.right * moveDistance
            : startPosition;
        rb.MovePosition(Vector3.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime));
    }

    void Toggle()
    {
        isHidden = !isHidden;
    }
}