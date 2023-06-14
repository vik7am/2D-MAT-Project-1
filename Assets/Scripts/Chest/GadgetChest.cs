using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class GadgetChest : Chest
    {
        [SerializeField] private Gadget gadgetPrefab;
        private Gadget gadget;

        protected override void InitializeItem()
        {
            gadget = Instantiate<Gadget>(gadgetPrefab);
            item = gadget.GetComponent<Item>();
            item.stackSize = 1;
        }

        public override void Interact(Interactor interactor){
            Inventory inventory = interactor.GetComponent<Inventory>();
            if(inventory){
                inventory.AddGadget(gadget);
            }
        }
    }
}
