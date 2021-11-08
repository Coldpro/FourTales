using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool outsideDoor = false;
        [SerializeField] private bool outsideKey = false;

        [SerializeField] private KeyInventory _KeyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (outsideDoor)
            { 
            doorObject = GetComponent<KeyDoorController>();
            }
        }
        
        public void objectInteraction()
        {
            if (outsideDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (outsideDoor)
            {
                _KeyInventory.hasOutsideKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}
