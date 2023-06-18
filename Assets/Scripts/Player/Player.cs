using System;
using UnityEngine;

namespace ProfessionalThief
{
    public class Player : MonoBehaviour
    {
        private PlayerInput playerInput;
        private Movement movement;

        private void Awake(){
            playerInput = GetComponent<PlayerInput>();
            movement = GetComponent<Movement>();
        }

        private void Start() {
            RegisterForEvents();
        }

        private void RegisterForEvents(){
            GameManager.Instance.onGameOver += DisablePlayerMovement;
        }

        private void DisablePlayerMovement(){
            movement.DisableMovement(true);
        }
    }
}
