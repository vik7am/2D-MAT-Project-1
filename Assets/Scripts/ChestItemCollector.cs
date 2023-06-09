using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class ChestItemCollector : MonoBehaviour
    {
        private Chest chest;

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.E)){
                CollectItem();
            }
        }

        private void CollectItem()
        {
            if(!chest) return;
            Item item = chest.GetItem();
            AddItemToInventory(item);
        }

        private void AddItemToInventory(Item item){
            Debug.Log(item.id);
        }

        private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.TryGetComponent<Chest>(out Chest chest)){
                this.chest = chest;
            }
        }

        private void OnCollisionExit2D(Collision2D other) {
            if(other.gameObject.TryGetComponent<Chest>(out Chest chest)){
                this.chest = null;
            }
        }
    }
}
