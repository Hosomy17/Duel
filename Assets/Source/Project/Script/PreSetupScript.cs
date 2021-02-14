using Framework.Managers;
using Framework.Scripts;
using Project.Manager;
using UnityEngine;

namespace Project.Scripts
{
    public class PreSetupScript : ScriptGeneric
    {

        public string FirstScene;
        public GameObject[] dontDestroy;

        void Start()
        {
            StartUpManagers();
            SetDontDestroyGmaeObjects();
            SetPreferenceSettings();
            SetSetup();


            LoadManager.Instance.StartLoadScreen(FirstScene);
        }

        private void StartUpManagers()
        {
            GameManagerGeneric.Instance.GetType();
        }

        private void SetDontDestroyGmaeObjects()
        {
            foreach (GameObject obj in dontDestroy)
                DontDestroyOnLoad(obj);
        }

        private void SetPreferenceSettings()
        {

        }

        private void SetSetup()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}