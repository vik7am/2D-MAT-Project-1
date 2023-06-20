using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class OpenPatrolPath : PatrolPath
    {
        private bool backtrackPath;
        private Stack<Vector2> waypointStack;
        private Stack<Vector2> traversedWaypointStack;
        private Stack<Vector2> temp;

        public override void InitializePath(){
            waypointStack = new Stack<Vector2>();
            traversedWaypointStack = new Stack<Vector2>();
            for(int i=pathCount-1; i>=0; i--){
                waypointStack.Push(transform.GetChild(i).position);
            }
        }

        public override Vector2 GetNextWaypoint(){
            if(waypointStack.Count == 0){
                temp = waypointStack;
                waypointStack = traversedWaypointStack;
                traversedWaypointStack = temp;
                traversedWaypointStack.Push(waypointStack.Pop());
            }
            Vector2 waypoint = waypointStack.Pop();
            traversedWaypointStack.Push(waypoint);
            return waypoint;
        }

        private void OnDrawGizmos() {
            pathCount = transform.childCount;
            DrawWaypoints();
            DrawLinesAroundWaypoints();
        }

        private void DrawLinesAroundWaypoints() {
            for(int i = 0; i<pathCount-1; i++){
                int j = GetNextWaypointIndex(i);
                Gizmos.DrawLine(GetWaypoint(i), GetWaypoint(j));
            }
        }

        public override int GetNextWaypointIndex(int index){
            index = (backtrackPath)? index-1 : index+1;
            if(index == 0 || index == pathCount)
                backtrackPath = !backtrackPath;
            return index;
        }
    }
}
