using Framework.Gamepads;
using Framework.Scripts;
using Framework.Tools;
using Project.Classes;
using Project.Controllers;

namespace Project.Scripts
{
    public class GameScript : ScriptGeneric
    {
        public Follower followerCamera;
        public TileMapGenerator tileMapGenerator;

        public CharacterClass characterClass1;
        public CharacterClass characterClass2;

        public int moves;

        private bool isTurncharacter1;
        private CharactController_ characterController;
        
        void Awake()
        {
            isTurncharacter1 = false;
            moves = 0;
        }

        void Start()
        {
            tileMapGenerator.Generate();

            characterController = new CharactController_();
            characterController.gameScript = this;
            characterController.tileMap = tileMapGenerator.tileMap;
            
            GetComponent<GamepadGeneric>().controller = characterController;

            SetNewTurn();
        }

        public void UpdateMove(int value)
        {
            moves += value;

            if (moves <= 0)
                SetNewTurn();
        }

        private void SetNewTurn()
        {
            CharacterClass characterClass;
            isTurncharacter1 = !isTurncharacter1;
            moves = 3;

            if (isTurncharacter1)
                characterClass = characterClass1;
            else
                characterClass = characterClass2;

            characterController.TrackObject(characterClass);
            followerCamera.target = characterClass.gameObject;
        }
    }    
}