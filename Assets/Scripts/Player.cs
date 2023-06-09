using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    [RequireComponent(typeof(PlayerMovement))]
    public class Player : MonoBehaviour
    {
        private PlayerMovement playerMovement;

        void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        private void Start() {
            GameManager.Instance.OnGameOver += playerMovement.DisableMovement;
        }
    }
}
