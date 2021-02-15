using Framework.Gamepads;
using Framework.Tools;
using Project.Controllers;
using UnityEngine;

namespace Project.Manager
{
    public class ExtraGameManager : MonoBehaviour
    {
        public TileMapGenerator tileMapGenerator;

        void Start()
        {
            var controller = new TileMapController();
            controller.tileMap = tileMapGenerator.tileMap;

            GetComponent<GamepadGeneric>().controller = controller;
        }
    }
}