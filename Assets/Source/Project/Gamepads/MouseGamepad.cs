using Framework.Gamepads;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Gamepads
{
    public class MouseGamepad : GamepadGeneric
    {
        private Dictionary<string, object> inputs;



        private void Awake()
        {
            inputs = new Dictionary<string, object>();
            inputs.Add("Cursor", Vector3.zero);
            inputs.Add("Click", false);
        }

        private void Update()
        {
            if (controller != null)
            {
                if (Input.GetMouseButtonDown(0))
                    inputs["Click"] = true;
                else
                    inputs["Click"] = false;

                inputs["Cursor"] = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                controller.NewInputs(inputs);
            }
        }
    }
}