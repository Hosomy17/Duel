using UnityEngine;
using Framework.Managers;
using Project.Manager;

namespace Project.Scripts
{
    public class PreSetupScript : MonoBehaviour
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