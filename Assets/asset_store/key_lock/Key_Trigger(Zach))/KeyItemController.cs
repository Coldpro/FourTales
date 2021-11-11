using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool OutsideDoor = false;
        [SerializeField] private bool OutsideKey = false;

        [SerializeField] private KeyInventory _keyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (OutsideDoor)
            { 
            doorObject = GetComponent<KeyDoorController>();
            }
        }
        
        public void ObjectInteraction()
        {
            if (OutsideDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (OutsideKey)
            {
                _keyInventory.hasOutsideKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}
