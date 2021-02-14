using UnityEngine;

namespace Framework.Tools
{
    public class Follower : MonoBehaviour
    {
        public GameObject target;
        public bool isLockX;
        public bool isLockY;
        public bool isLockZ;

        [Range(0, 1)]
        public float xSmooth;
        [Range(0, 1)]
        public float ySmooth;
        [Range(0, 1)]
        public float zSmooth;

        private Vector3 newPos;
        void Update()
        {
            if (target)
            {
                newPos = transform.position;

                if (!isLockX)
                    newPos.x = Mathf.Lerp(transform.position.x, target.transform.position.x, xSmooth * Time.deltaTime);

                if (!isLockY)
                    newPos.y = Mathf.Lerp(transform.position.y, target.transform.position.y, ySmooth * Time.deltaTime);

                if (!isLockZ)
                    newPos.z = Mathf.Lerp(transform.position.z, target.transform.position.z, zSmooth * Time.deltaTime);


                transform.position = newPos;
            }
        }
    }
}