using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class StunnedState : EnemyState
    {
        private Movement movement;
        
        public StunnedState(EnemyStateMachine enemyStateMachine) : base(enemyStateMachine){
            movement = enemyStateMachine.Movement;
        }

        public override void OnStateEnter(){
            movement.DisableMovement(true);
        }

        public override void Update(){

        }
    }
}
