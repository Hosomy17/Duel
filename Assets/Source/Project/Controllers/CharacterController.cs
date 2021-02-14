using Framework.Classes;
using Framework.Controllers;
using Project.Classes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Project.Controllers
{
    public class CharacterController : ControllerGeneric
    {
        private CharacterClass characterClass;

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

                characterClass.MoveToPosition(position);
            }
        }

        private bool CanMove(Vector3 position)
        {
            var cp = tileMap.WorldToCell(position);
            return tileMap.HasTile(cp);
        }
    }
}