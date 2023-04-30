using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DreamWrldCtrl : MonoBehaviour
{
 public void DreamAppear(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("333" + context.phase);
        }
    }
    public void DreamDisappear(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("555" + context.phase);
        }
    }
}
