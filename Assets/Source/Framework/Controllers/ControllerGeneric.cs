using System.Collections.Generic;
using UnityEngine;

namespace Framework.Controllers
{
    public abstract class ControllerGeneric
    {
        public abstract void NewInputs(Dictionary<string, object> ipt);

        public abstract void TrackObject(GameObject obj);
    }
}