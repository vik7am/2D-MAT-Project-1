using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public interface IInteractableItem{
        void Interact(GameObject gameObject);
    }

    public abstract class Chest : MonoBehaviour, IInteractableItem
    {
        public bool empty;
        public Item item;

        private void Start(){
            empty = false;
            InitializeItem();
        }

        public abstract void Interact(GameObject gameObject);
        
        protected abstract void InitializeItem();
        
    }
}
