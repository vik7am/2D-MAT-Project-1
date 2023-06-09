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

        public override void InitializeItem()
        {
            valuable = Instantiate(valuablePrefab);
            valuable.data = valuableData;
            item = valuable.GetComponent<Item>();
            item.stackSize = 2;
        }
    }
}
