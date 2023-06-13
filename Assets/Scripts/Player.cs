using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProfessionalThief
{
    public class Player : MonoBehaviour
    {
        private PlayerInput playerInput;

        void Awake()
        {
            playerInput = GetComponent<PlayerInput>();
        }

        private void Start() {
            GameManager.Instance.OnGameOver += playerInput.DisablePlayerInput;
        }
    }
}
