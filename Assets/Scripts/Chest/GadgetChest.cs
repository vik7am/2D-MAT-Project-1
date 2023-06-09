using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class GadgetChest : Chest
    {
        public Gadget gadgetPrefab;
        private Gadget gadget;

        public override void InitializeItem()
        {
            gadget = Instantiate<Gadget>(gadgetPrefab);
            item = gadget.GetComponent<Item>();
            item.stackSize = 1;
        }
    }
}
