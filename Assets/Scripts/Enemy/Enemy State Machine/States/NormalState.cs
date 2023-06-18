using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class NormalState : EnemyState
    {
        private Movement movement;

        public NormalState(EnemyStateMachine enemyStateMachine) : base(enemyStateMachine){
            movement = enemyStateMachine.Movement;
        }

        public override void OnStateEnter(){
            movement.DisableMovement(false);
        }

        public override void Update(){
            
        }
    }
}
