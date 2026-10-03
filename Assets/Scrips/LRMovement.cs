using UnityEngine;

public class LeftRightMover : MonoBehaviour
{
    public float amplitude = 2f;   
    public float speed = 2f;       

    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(startX + offset, transform.position.y, transform.position.z);
    }
}