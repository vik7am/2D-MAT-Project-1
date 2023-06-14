using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class Inventory : MonoBehaviour
    {
        private Dictionary<ValuableId, Valuable> valuableList;
        private Dictionary<GadgetId, Gadget> gadgetList;
        private int totalTake;

        private void Start(){
            valuableList = new Dictionary<ValuableId, Valuable>();
            gadgetList = new Dictionary<GadgetId, Gadget>();
            totalTake = 0;
        }

        public void AddGadget(Gadget gadget){
            gadgetList.Add(gadget.id, gadget);
            Debug.Log(gadget);
        }

        public void AddValuable(Valuable valuable){
            valuableList.Add(valuable.id, valuable);
            Debug.Log(valuable);
        }

        public bool HasGadget(GadgetId gadgetId){
            return gadgetList.ContainsKey(gadgetId);
        }

        public Gadget GetGadget(GadgetId gadgetId){
            if(!HasGadget(gadgetId)) return null;
            return gadgetList[gadgetId];
        }

        private void UpdateTotalTake(Valuable valuable, int stackSize){
            totalTake += valuable.data.value * stackSize;
            Debug.Log("Take: " + totalTake);
        }
    }
}
