using Framework.Tools;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TileMapGenerator))]
public class TileMapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {

        DrawDefaultInspector();

        TileMapGenerator tileMapGenerator = (TileMapGenerator)target;
        if (GUILayout.Button("Generate TileMap"))
        {
            tileMapGenerator.Generate();
        }
    }
}