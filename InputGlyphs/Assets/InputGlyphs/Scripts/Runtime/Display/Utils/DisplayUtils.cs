using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InputGlyphs.Display
{
    public static class DisplayUtils
    {
        public static InputControlList<InputDevice> CollectDevicesForControlScheme(InputControlScheme controlScheme, PlayerInput playerInput = null)
        {
            var pickResult = playerInput != null ? controlScheme.PickDevicesFrom(playerInput.devices) : default;
            if (!pickResult.isSuccessfulMatch)
            {
                pickResult = controlScheme.PickDevicesFrom(InputSystem.devices);
            }

            return pickResult.devices;
        }
    }
}
