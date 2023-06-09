using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public enum GadgetId{TORCH, STUN_GUN, NIGHT_VISION_GOOGLES}
    
    [RequireComponent(typeof(Item))]
    public abstract class  Gadget : MonoBehaviour
    {
        public GadgetId id;
        private Item item;

        private void Awake() {
            item = GetComponent<Item>();
        }

        protected virtual void Start() {
            item.id = ItemId.GADGET;
        }
    }
        
}
