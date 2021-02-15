using Project.Enums;
using UnityEngine;

namespace Project.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New PowerUp", menuName = "ScriptableObjects/PowerUp")]
    public class PowerUpScriptableObject : ScriptableObject
    {
        public int extraHp;
        public int extraAtk;
        public int extraDice;
        public int extraMove;

        public Sprite image;

        public Tier tier;
    }
}