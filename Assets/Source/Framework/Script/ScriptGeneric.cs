using Framework.Managers;
using UnityEngine;

namespace Framework.Scripts
{
    public class ScriptGeneric : MonoBehaviour
    {

        protected GameManagerGeneric gameManager;

        void Awake()
        {
            gameManager = GameManagerGeneric.Instance;
        }
    }
}