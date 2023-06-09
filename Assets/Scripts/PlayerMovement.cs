using UnityEngine;

namespace ProfessionalThief
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float speed;
        Rigidbody2D body;
        Vector2 currentVelocity;
        private Vector2 movementDirection;
        private bool movementDisabled;

        void Awake(){
            movementDisabled = false;
            body = GetComponent<Rigidbody2D>();
        }

        void Update(){
            if(movementDisabled)
                return;
            GetPlayerMovementInput();
            UpdatePlayerLookDirection();
        }

        void FixedUpdate(){
            if(movementDisabled)
                return;
            UpdatePlayerMovement();
        }

        private void GetPlayerMovementInput(){
            Vector2 movementInput;
            movementInput.x = Input.GetAxisRaw("Horizontal");
            movementInput.y = Input.GetAxisRaw("Vertical");
            movementDirection = movementInput.normalized;
        }

        private void UpdatePlayerMovement(){
            body.velocity = movementDirection * speed;
        }

        void UpdatePlayerLookDirection(){
            if(movementDirection == Vector2.zero) return;
            transform.up = movementDirection;
        }

        public void DisableMovement(){
            movementDisabled = true;
            currentVelocity = Vector2.zero;
        }
    }
}
