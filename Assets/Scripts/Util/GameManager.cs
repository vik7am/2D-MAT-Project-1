using System;
using UnityEngine;

namespace ProfessionalThief
{
    public class GameManager : GenericMonoSingleton<GameManager>
    {
        public event Action OnGameOver;

        public void ActivateAlarm(){
            Debug.Log("Game Over");
            OnGameOver?.Invoke();
        }
    }
}
