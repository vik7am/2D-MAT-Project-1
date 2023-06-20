using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public abstract class PatrolPath : MonoBehaviour
    {
        protected int pathCount;

        private void Awake() {
            pathCount = transform.childCount;
            InitializePath();
        }

        protected void DrawWaypoints() {
            for(int i = 0; i<pathCount; i++){
                Gizmos.DrawSphere(GetWaypoint(i), 0.2f);
            }
        }

        public Vector2 GetWaypoint(int index){
            return transform.GetChild(index).position;
        }

        public Vector2 GetNextWaypoint(int index){
            int nextWaypointIndex = GetNextWaypointIndex(index);
            return GetWaypoint(nextWaypointIndex);
        }

        public abstract int GetNextWaypointIndex(int index);
        public abstract void InitializePath();
        public abstract Vector2 GetNextWaypoint();

    }
}
