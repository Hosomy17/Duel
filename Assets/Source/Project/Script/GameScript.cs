using Framework.Scripts;
using Framework.Tools;

namespace Project.Scripts
{
    public class GameScript : ScriptGeneric
    {
        public TileMapGenerator tileMapGenerator;

        void Start()
        {
            tileMapGenerator.Generate();
        }
    }    
}