using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public enum ItemId {VALUABLE, GADGET}

    public class Item : MonoBehaviour
    {
        public ItemId id;
        public int stackSize;
    }
}
