using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class Inventory : MonoBehaviour
    {
        Dictionary<ValuableId, Valuable> valuableList;
        Dictionary<GadgetId, Gadget> gadgetList;
        private int totalTake;

        void Start()
        {
            valuableList = new Dictionary<ValuableId, Valuable>();
            gadgetList = new Dictionary<GadgetId, Gadget>();
            totalTake = 0;
        }

        public void AddItem(Item item){
            if(item.TryGetComponent<Valuable>(out Valuable valuable)){
                valuableList.Add(valuable.id, valuable);
                UpdateTotalTake(valuable, item.stackSize);
            }
            else if(item.TryGetComponent<Gadget>(out Gadget gadget)){
                gadgetList.Add(gadget.id, gadget);
            }
        }

        public bool HasGadget(GadgetId gadgetId){
            return gadgetList.ContainsKey(gadgetId);
        }

        public Gadget GetGadget(GadgetId gadgetId){
            if(!HasGadget(gadgetId)) return null;
            return gadgetList[gadgetId];
        }

        public void UpdateTotalTake(Valuable valuable, int stackSize){
            totalTake += valuable.data.value * stackSize;
            Debug.Log("Take: " + totalTake);
        }
    }
}
