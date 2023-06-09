using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class PlayerDetector : MonoBehaviour
    {
        [SerializeField] private float detectionRange;
        

        private void Start() {
            
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.GetComponent<Player>()){
                GameManager.Instance.ActivateAlarm();
            }
        }
    }
}
