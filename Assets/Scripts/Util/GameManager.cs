using System;

namespace ProfessionalThief
{
    public class GameManager : GenericMonoSingleton<GameManager>
    {
        public event Action OnGameOver;

        public void ActivateAlarm(){
            OnGameOver?.Invoke();
        }
    }
}
