using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public abstract class Chest : MonoBehaviour
    {
        public bool empty;
        public Item item;

        void Start()
        {
            empty = false;
            InitializeItem();
        }

        public Item GetItem(){
            return item;
        }
        
        public abstract void InitializeItem();
        
    }
}
