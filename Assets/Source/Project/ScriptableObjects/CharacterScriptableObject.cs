using UnityEngine;

namespace Project.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Character", menuName = "ScriptableObjects/Character")]
    public class CharacterScriptableObject : ScriptableObject
    {
        public string characterName;

        public int hp;
        public int atk;

        public Sprite sprite;
    }
}
