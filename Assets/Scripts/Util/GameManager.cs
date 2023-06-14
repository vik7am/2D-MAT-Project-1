using System;
using UnityEngine;
using UnityEngine.Events;

namespace ProfessionalThief
{
    public class GameManager : GenericMonoSingleton<GameManager>
    {
        public UnityEvent onGameOver;

        public void ActivateAlarm(){
            Debug.Log("Game Over");
            onGameOver?.Invoke();
        }
    }
}
