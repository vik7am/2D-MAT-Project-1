using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class Torch : Gadget
    {
        protected override void Start() {
            base.Start();
            id = GadgetId.TORCH;
        }
    }
}
