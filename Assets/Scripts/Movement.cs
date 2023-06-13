using System;
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

        void Awake(){
            rigidbody2D = GetComponent<Rigidbody2D>();
            movementInput = GetComponent<IMovementInput>();
        }

        void Update(){
            UpdateMovementDirection();
            UpdateLookDirection();
        }

        void FixedUpdate(){
            UpdateMovement();
        }

        private void UpdateMovementDirection(){
            if(movementInput != null)
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
