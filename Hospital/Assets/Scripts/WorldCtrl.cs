using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WorldCtrl : MonoBehaviour
{
    public GameObject _Dream;
    public GameObject _Night;
    public void DreamCall(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _Dream.SetActive(true);
            _Night.SetActive(false);
            Debug.Log("DreamAppear" + context.phase);
        }
    }
    public void NightCall(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _Dream.SetActive(false);
            _Night.SetActive(true);
            Debug.Log("NightAppear" + context.phase);
        }
    }
    public void NormalCall(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _Dream.SetActive(false);
            _Night.SetActive(false);
            Debug.Log("NormalAppear" + context.phase);
        }
    }
}
