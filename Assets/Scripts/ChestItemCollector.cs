using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    [RequireComponent(typeof(Inventory))]
    public class ChestItemCollector : MonoBehaviour
    {
        private Chest chest;
        private Inventory inventory;

        private void Awake() {
            inventory = GetComponent<Inventory>();
        }

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
            inventory.AddItem(item);
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
