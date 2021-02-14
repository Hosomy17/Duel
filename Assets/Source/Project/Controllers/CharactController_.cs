using Framework.Classes;
using Framework.Controllers;
using Project.Classes;
using Project.Scripts;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Project.Controllers
{
    public class CharactController_ : ControllerGeneric
    {
        private CharacterClass characterClass;

        public GameScript gameScript;
        public Tilemap tileMap;

        public override void NewInputs(Dictionary<string, object> ipt)
        {
            if( (bool)ipt["Click"])
            {
                MoveToTile((Vector3)ipt["Cursor"]);
            }
        }

        public override void TrackObject(ClassGeneric obj)
        {
            characterClass = (CharacterClass) obj;
        }

        private void MoveToTile(Vector3 position)
        {
            if(CanMove(position))
            {
                var cp = tileMap.WorldToCell(position);
                position = tileMap.CellToWorld(cp);

                characterClass.currectTile = cp;
                characterClass.MoveToPosition(position);

                gameScript.UpdateMove(-1);
            }
        }

        private bool CanMove(Vector3 position)
        {
            var cp = tileMap.WorldToCell(position);

            var distanceX = Mathf.Abs(characterClass.currectTile.x - cp.x);
            var distanceY = Mathf.Abs(characterClass.currectTile.y - cp.y);
            var distance = Mathf.Max(distanceX, distanceY);

            return tileMap.HasTile(cp) && distance == 1 && gameScript.CanMove(cp);
        }
    }
}