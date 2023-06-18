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
            RegisterEvents();
        }

        private void RegisterEvents(){
            GameManager.Instance.onGameOver += DisablePlayerInput;
        }

        public Vector2 GetMovementDirection(){
            movementInput.x = Input.GetAxisRaw("Horizontal");
            movementInput.y = Input.GetAxisRaw("Vertical");
            return movementInput.normalized;
        }

        public void DisablePlayerInput(){
            inputDisabled = true;
        }
    }
}
