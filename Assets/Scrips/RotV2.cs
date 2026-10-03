using UnityEngine;

public class RotatorV2 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(-15, 0, 0) * Time.deltaTime * 2);
    }

}