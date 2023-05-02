using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace animcontrol
{
    public class AnimInputs : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                AnimCtrl.Instance.MoveLeft = true;
            }
            else
            {
                AnimCtrl.Instance.MoveLeft = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                AnimCtrl.Instance.MoveRight = true;
            }
            else
            {
                AnimCtrl.Instance.MoveRight = false;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                AnimCtrl.Instance.Jumped = true;
            }
             else
            {
                AnimCtrl.Instance.Jumped = false;
                
            }
        }
    }
}
