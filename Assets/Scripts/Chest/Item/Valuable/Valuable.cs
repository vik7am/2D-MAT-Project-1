using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public enum ValuableId{CASH, SILVER_COIN, GOLD_COIN}

    [RequireComponent(typeof(Item))]
    public class Valuable : MonoBehaviour
    {
        public ValuableId id;
        public ValuableData data;
        private Item item;

        private void Awake() {
            item = GetComponent<Item>();
        }

        private void Start() {
            item.id = ItemId.VALUABLE;
            id = data.valuableId;
        }
    }
}
