using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class Interactor : MonoBehaviour
    {
        private IInteractableItem interactableItem;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.E)){
                InteractWithItem();
            }
        }

        private void InteractWithItem(){
            if(interactableItem == null) return;
            interactableItem.Interact(gameObject);
        }

        private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.TryGetComponent<IInteractableItem>(out IInteractableItem item)){
                this.interactableItem = item;
            }
        }

        private void OnCollisionExit2D(Collision2D other) {
            if(other.gameObject.TryGetComponent<IInteractableItem>(out IInteractableItem item)){
                this.interactableItem = null;
            }
        }
    }
}
