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
            var i = GameManagerGeneric.Instance;

            foreach (GameObject obj in dontDestroy)
                DontDestroyOnLoad(obj);

            LoadManager.Instance.StartLoadScreen(FirstScene);
        }
    }
}