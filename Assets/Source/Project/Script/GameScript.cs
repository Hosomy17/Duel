using Framework.Gamepads;
using Framework.Scripts;
using Framework.Tools;
using Project.Classes;
using Project.Controllers;

namespace Project.Scripts
{
    public class GameScript : ScriptGeneric
    {
        public TileMapGenerator tileMapGenerator;

        public CharacterClass characterClass;

        void Start()
        {
            tileMapGenerator.Generate();

            StartUpGamepad();
        }

        private void StartUpGamepad()
        {
            var controller = new CharacterController();
            controller.TrackObject(characterClass);

            controller.tileMap = tileMapGenerator.tileMap;

            GetComponent<GamepadGeneric>().controller = controller;
        }
    }    
}