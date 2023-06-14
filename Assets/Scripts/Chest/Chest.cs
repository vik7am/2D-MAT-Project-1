using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public interface IInteractableItem{
        void Interact(Interactor interactor);
    }

    public abstract class Chest : MonoBehaviour, IInteractableItem
    {
        private bool isEmpty;

        public bool IsEmpty {get => isEmpty;}

        private void Start(){
            isEmpty = false;
            InitializeItem();
        }

        public abstract void Interact(Interactor interactor);
        
        protected abstract void InitializeItem();
        
    }
}
