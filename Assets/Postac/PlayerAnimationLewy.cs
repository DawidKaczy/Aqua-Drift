using UnityEngine;
using UnityEngine.InputSystem;

public class PlayMixamoAnimationV2 : MonoBehaviour
{
    public Animator animator; 

    void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame) 
        {
            animator.SetTrigger("TrClose");
        }
    }
}
