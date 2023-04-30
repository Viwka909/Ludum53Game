using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KbMovement
{
    public class KbInbut : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                VirtulalInput.Instance.NightmareSt = true;
                VirtulalInput.Instance.NormalSt = false;
                VirtulalInput.Instance.DreamSt = false;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                VirtulalInput.Instance.NormalSt = true;
                 VirtulalInput.Instance.NightmareSt = false;
                 VirtulalInput.Instance.DreamSt = false;
            }

            else if (Input.GetKey(KeyCode.E))
            {
                VirtulalInput.Instance.DreamSt = true;
                VirtulalInput.Instance.NormalSt = false;
                 VirtulalInput.Instance.NightmareSt = false;
            }
        }
    }

}
