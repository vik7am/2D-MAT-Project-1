using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class ClosedPatrolPath : PatrolPath
    {
        private Queue<Vector2> waypointQueue;

        public override Vector2 GetNextWaypoint(){
            Vector2 waypoint = waypointQueue.Dequeue();
            waypointQueue.Enqueue(waypoint);
            return waypoint;
        }

        public override void InitializePath(){
            waypointQueue = new Queue<Vector2>();
            for(int i=0; i< pathCount; i++){
                waypointQueue.Enqueue(transform.GetChild(i).position);
            }
        }

        private void OnDrawGizmos() {
            pathCount = transform.childCount;
            DrawWaypoints();
            DrawLinesAroundWaypoints();
        }

        protected void DrawLinesAroundWaypoints(){
            for(int i = 0; i<pathCount; i++){
                int j = GetNextWaypointIndex(i);
                Gizmos.DrawLine(GetWaypoint(i), GetWaypoint(j));
            }
        }

        public override int GetNextWaypointIndex(int index){
            if(index == pathCount-1)
                return 0;
            return index+1;
        }
    }
}
