using UnityEngine;
using UnityEngine.InputSystem;

public class PlayMixamoAnimation : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            animator.SetTrigger("TrOpen");
        }
    }
}
