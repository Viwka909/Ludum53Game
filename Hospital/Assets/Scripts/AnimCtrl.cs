using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace animcontrol
{
    public class AnimCtrl : MonoBehaviour
    {
        public static AnimCtrl Instance = null;
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else if (Instance != this)
            {
                Destroy(this.gameObject);
            }
        }
        public bool MoveRight;
        public bool MoveLeft;
        public bool Jumped;
    }
}
