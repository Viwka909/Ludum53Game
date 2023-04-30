using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KbMovement
{
    public class VirtulalInput : MonoBehaviour
    {
        public static VirtulalInput Instance = null;

        private void Awake() {
            if (Instance == null)
            {
                Instance = this;
            }
            else if(Instance != this){
                Destroy(this.gameObject);
            }
        }
        public bool NightmareSt;
        public bool NormalSt;
        public bool DreamSt;
        
    }
}


