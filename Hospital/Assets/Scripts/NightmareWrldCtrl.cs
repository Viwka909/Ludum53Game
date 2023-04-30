using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class NightmareWrldCtrl : MonoBehaviour
{
    public void NightAppear(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("123" + context.phase);
        }
    }
    public void NightDisappear(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("321" + context.phase);
        }
    }
}
