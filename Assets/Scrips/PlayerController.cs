using UnityEngine;
using UnityEngine.InputSystem;

public class KayakMovement : MonoBehaviour
{
    public float przyspiesznie = 3f;
    public float zwolnienie = 5f;
    public float maxSpeed = 10f;
    private float currentSpeed = 0f;
    private float boostSpeed = 0f;
    private float boostDecay = 4f;

    public AudioSource audioSource;

    public void AddBoost(float amount)
    {
        boostSpeed = amount;
    }

    void Update()
    {
        if (MenuController.inputBlocked)
            return;

        if (Keyboard.current == null)
            return;

        bool naWodzie = transform.position.y <= 1.5f;

        if (naWodzie)
        {
            if (Keyboard.current.aKey.wasPressedThisFrame)
            {
                transform.Rotate(Vector3.up, 30);
                Accelerate(0.5f);

                if (audioSource != null)
                    audioSource.Play(); 
            }

            if (Keyboard.current.dKey.wasPressedThisFrame)
            {
                transform.Rotate(Vector3.up, -30);
                Accelerate(0.5f);

                if (audioSource != null)
                    audioSource.Play(); 
            }
        }

        currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, zwolnienie * Time.deltaTime);

        boostSpeed = Mathf.MoveTowards(boostSpeed, 0, boostDecay * Time.deltaTime);

        float finalSpeed = currentSpeed + boostSpeed;

        transform.Translate(Vector3.forward * finalSpeed * Time.deltaTime);
    }

    private void Accelerate(float multiplier)
    {
        currentSpeed += przyspiesznie * multiplier;
        currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxSpeed);
    }
}
