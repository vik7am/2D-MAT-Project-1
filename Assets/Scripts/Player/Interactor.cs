using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class Interactor : MonoBehaviour
    {
        private IInteractableItem interactableItem;
        [SerializeField] private UIManager uIManager;

        private void Update(){
            if(Input.GetKeyDown(KeyCode.E)){
                InteractWithItem();
            }
        }

        private void InteractWithItem(){
            if(interactableItem == null) return;
            interactableItem.Interact(this);
        }

        private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.TryGetComponent<IInteractableItem>(out IInteractableItem item)){
                this.interactableItem = item;
                uIManager.ToggleInteractionUI(true);
            }
        }

        private void OnCollisionExit2D(Collision2D other) {
            if(other.gameObject.TryGetComponent<IInteractableItem>(out IInteractableItem item)){
                this.interactableItem = null;
                uIManager.ToggleInteractionUI(false);
            }
        }
    }
}
