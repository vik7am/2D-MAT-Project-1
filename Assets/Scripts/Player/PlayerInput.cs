using System;
using UnityEngine;

namespace ProfessionalThief
{
    public class PlayerInput : MonoBehaviour, IMovementInput
    {
        private Vector2 movementInput;

        private void Start() {
            RegisterEvents();
        }

        private void RegisterEvents(){
        }

        public Vector2 GetMovementDirection(){
            movementInput.x = Input.GetAxisRaw("Horizontal");
            movementInput.y = Input.GetAxisRaw("Vertical");
            return movementInput.normalized;
        }
    }
}
