using UnityEngine;

namespace ProfessionalThief
{
    public interface IMovementInput{
        Vector2 GetMovementDirection();
    }

    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed;
        private new Rigidbody2D rigidbody2D;
        private Vector2 direction;
        private IMovementInput movementInput;

        private void Awake(){
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update(){
            if(movementInput == null)
                return;
            UpdateMovementDirection();
            UpdateLookDirection();
        }

        private void FixedUpdate(){
            if(movementInput == null)
                return;
            UpdateMovement();
        }

        public void SetMovementInput(IMovementInput movementInput){
            this.movementInput = movementInput;
        }

        private void UpdateMovementDirection(){
            direction = movementInput.GetMovementDirection();
        }

        private void UpdateLookDirection(){
            if(direction == Vector2.zero) return;
            transform.up = direction;
        }

        private void UpdateMovement(){
            rigidbody2D.velocity = direction * speed;
        }
    }
}
