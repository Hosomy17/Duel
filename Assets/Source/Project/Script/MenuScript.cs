using Framework.Scripts;
using Project.Manager;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Project.Scripts
{
    public class MenuScript : ScriptGeneric
    {
        
        public void OpenGame()
        {
            DisableNavegation();
            LoadManager.Instance.StartLoadScreen("GameScene");
        }
        public void ExitGame()
        {
            DisableNavegation();
            GameManager.Instance.ExitGame();
        }

        private void DisableNavegation()
        {
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}