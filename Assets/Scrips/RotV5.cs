using UnityEngine;

public class RotatorV5 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, -30, 0) * Time.deltaTime * 1);
    }

}