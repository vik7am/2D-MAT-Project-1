using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class Patroling : MonoBehaviour, IMovementInput
    {
        [SerializeField] private PatrolPath patrolPath;
        [SerializeField] private float stoppingDistance;
        private Vector2 currentWayPoint;
        private Vector2 nextWaypoint;
        private Vector2 movementInput;
        private Movement movement;
        
        void Start(){
            currentWayPoint = patrolPath.GetWaypoint(0);
            nextWaypoint = patrolPath.GetNextWaypoint();
            transform.position = currentWayPoint;
            movementInput = nextWaypoint - currentWayPoint;
        }

        private void Update(){
            CheckDestination();
        }

        private void CheckDestination()
        {
            if(Vector2.Distance(transform.position, nextWaypoint) < stoppingDistance){
                currentWayPoint = nextWaypoint;
                nextWaypoint = patrolPath.GetNextWaypoint();
                movementInput = nextWaypoint - currentWayPoint;
            }
        }

        public Vector2 GetMovementDirection(){
            return movementInput.normalized;
        }
    }
}
