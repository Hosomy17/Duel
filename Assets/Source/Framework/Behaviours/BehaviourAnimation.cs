using UnityEngine;

namespace Framework.Behaviours
{
    public static class BehaviourAnimation
    {
        public static void Play(GameObject obj, string ani)
        {
            obj.GetComponent<Animator>().Play(ani);
        }
    }
}