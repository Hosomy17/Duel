using Framework.Classes;
using Framework.Controllers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Project.Controllers
{
    public class TileMapController : ControllerGeneric
    {
        private Vector3Int lastCell;

        public Tilemap tileMap;
        public override void NewInputs(Dictionary<string, object> ipt)
        {
            HighlightTile((Vector3)ipt["Cursor"]);
        }

        public override void TrackObject(ClassGeneric obj)
        {
        }

        private void HighlightTile(Vector3 position)
        {
            
            var cp = tileMap.WorldToCell(position);
            if(cp != lastCell)
            {
                if (lastCell != null)
                {
                    tileMap.SetColor(lastCell, Color.white);
                    tileMap.SetTileFlags(lastCell , TileFlags.LockAll);
                }

                tileMap.SetTileFlags(lastCell, TileFlags.None);
                tileMap.SetColor(cp, Color.red);
                lastCell = cp;
            }
        }
    }
}