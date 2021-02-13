using Framework.Behaviours;
using Framework.Managers;
using System.Collections;
using UnityEngine;

namespace Project.Manager
{
    public class LoadManager : MonoBehaviour
    {

        public GameObject curtain;
        public float waitBeforeLoad;

        public static LoadManager Instance { get; private set; }


        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }
        public void StartLoadScreen(string scene)
        {
            BehaviourAnimation.Play(curtain, "Close");
            StartCoroutine(LoadScene(scene));
        }

        private IEnumerator LoadScene(string scene)
        {
            yield return new WaitForSeconds(waitBeforeLoad);

            yield return StartCoroutine(GameManagerGeneric.Instance.LoadSceneAsync(scene));

            EndLoadScreen();

            yield return null;
        }

        private void EndLoadScreen()
        {
            BehaviourAnimation.Play(curtain, "Open");
        }
    }
}