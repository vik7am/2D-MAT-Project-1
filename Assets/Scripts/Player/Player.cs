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
            movement.SetMovementInput(playerInput);
            GameManager.Instance.OnGameOver += playerInput.DisablePlayerInput;
        }
    }
}
