using System;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Framework.Tools
{
    public class TileMapGenerator : MonoBehaviour
    {
        public Tilemap tileMap;
        public TileInfo[] tiles;

        [Serializable]
        public struct TileInfo
        {
            public Tile tile;
            public int factor;
        }

        public int tileMapWidth;
        public int tileMapHeight;

        [Range(0, 1)]
        public float sizeHole;

        [Range(0, 1)]
        public float sizeEdge;


        public void Generate()
        {
            var cr = new CustomRandom();
            var index = 0;
            tileMap.ClearAllTiles();
            foreach (TileInfo obj in tiles)
            {
                cr.NewIndex(index.ToString(), obj.factor);
                index++;
            }

            for (var i = 0; i < tileMapWidth; i++)
            {
                for (var j = 0; j < tileMapHeight; j++)
                {
                    if (Vector2Int.Distance(new Vector2Int(i, j), new Vector2Int(tileMapWidth / 2, tileMapHeight / 2)) < sizeHole * Math.Min(tileMapWidth, tileMapHeight))
                        continue;

                    if (Vector2Int.Distance(new Vector2Int(i, j), new Vector2Int(tileMapWidth / 2, tileMapHeight / 2)) > sizeEdge * Math.Max(tileMapWidth, tileMapHeight))
                        continue;

                    var r = Convert.ToInt32(cr.Generate());
                    var pos = new Vector3Int(i, j, 0);
                    tileMap.SetTile(pos, tiles[r].tile);
                }
            }
        }
    }
}