using Framework.Classes;
using Project.ScriptableObjects;
using UnityEngine;

namespace Project.Classes
{
    public class CharacterClass : ClassGeneric
    {
        public int maxHp;
        public int hp;
        public int atk;

        public int atkBns;
        public int diceBns;

        public Vector3Int currectTile;

        public CharacterScriptableObject characterScriptable;

        void Awake()
        {
            SetScriptableObject();
        }

        private void SetScriptableObject()
        {
            if (characterScriptable)
            {
                maxHp = characterScriptable.hp;
                hp = characterScriptable.hp;

                atk = characterScriptable.atk;

                GetComponent<SpriteRenderer>().sprite = characterScriptable.sprite;
            }
        }

        public void MoveToPosition(Vector3 position)
        {
            transform.position = position;
        }
    }
}