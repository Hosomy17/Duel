using Framework.Classes;
using System.Collections.Generic;

namespace Framework.Controllers
{
    public abstract class ControllerGeneric
    {
        public abstract void NewInputs(Dictionary<string, object> ipt);

        public abstract void TrackObject(ClassGeneric obj);
    }
}