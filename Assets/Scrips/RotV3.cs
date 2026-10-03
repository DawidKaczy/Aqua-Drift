using UnityEngine;

public class RotatorV3 : MonoBehaviour
{
    public float rotationSpeed = 60f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -30) * Time.deltaTime * rotationSpeed / 30f);
    }
}