using System;
using UnityEngine;

namespace ProfessionalThief
{
    public class PlayerInput : MonoBehaviour, IMovementInput
    {
        private Vector2 movementInput;
        private bool inputDisabled;

        private void Start() {
            inputDisabled = false;
        }

        public Vector2 GetMovementDirection(){
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
