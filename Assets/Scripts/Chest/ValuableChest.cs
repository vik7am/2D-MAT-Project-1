using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class ValuableChest : Chest
    {
        [SerializeField] private Valuable valuablePrefab;
        [SerializeField] private ValuableData valuableData;
        private Valuable valuable;

        protected override void InitializeItem(){
            valuable = Instantiate(valuablePrefab);
            valuable.data = valuableData;
            item = valuable.GetComponent<Item>();
            item.stackSize = 2;
        }

        public override void Interact(Interactor interactor){
            Inventory inventory = interactor.GetComponent<Inventory>();
            if(inventory){
                inventory.AddValuable(valuable);
            }
        }
    }
}
