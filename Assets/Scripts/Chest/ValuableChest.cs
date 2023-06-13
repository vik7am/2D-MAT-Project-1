using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class ValuableChest : Chest
    {
        [SerializeField] Valuable valuablePrefab;
        [SerializeField] ValuableData valuableData;
        Valuable valuable;

        protected override void InitializeItem(){
            valuable = Instantiate(valuablePrefab);
            valuable.data = valuableData;
            item = valuable.GetComponent<Item>();
            item.stackSize = 2;
        }

        public override void Interact(GameObject gameObject){
            Inventory inventory = gameObject.GetComponent<Inventory>();
            if(inventory){
                inventory.AddValuable(valuable);
            }
        }
    }
}
