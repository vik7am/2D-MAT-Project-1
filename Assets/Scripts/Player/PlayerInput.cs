using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class PlayerInput : MonoBehaviour, IMovementInput
    {
        Vector2 movementInput;
        bool inputDisabled;

        private void Start() {
            inputDisabled = false;
        }

        public Vector2 GetMovementDirection()
        {
            if(inputDisabled)
                return Vector2.zero;
            movementInput.x = Input.GetAxisRaw("Horizontal");
            movementInput.y = Input.GetAxisRaw("Vertical");
            return movementInput.normalized;
        }

        public void DisablePlayerInput(){
            inputDisabled = true;
        }
    }
}
