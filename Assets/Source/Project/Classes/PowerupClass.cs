using Framework.Classes;
using Project.ScriptableObjects;
using UnityEngine;

namespace Project.Classes
{
    public class PowerupClass : ClassGeneric
    {
        public int extraHp;
        public int extraAtk;
        public int extraDice;
        public int extraMove;

        public PowerUpScriptableObject powerUpScriptable;

        void Awake()
        {
            SetScriptableObject();
        }

        private void SetScriptableObject()
        {
            extraHp = powerUpScriptable.extraHp;
            extraAtk = powerUpScriptable.extraAtk;
            extraDice = powerUpScriptable.extraDice;
            extraMove = powerUpScriptable.extraMove;

            GetComponent<SpriteRenderer>().sprite = powerUpScriptable.image;
        }

    }
}