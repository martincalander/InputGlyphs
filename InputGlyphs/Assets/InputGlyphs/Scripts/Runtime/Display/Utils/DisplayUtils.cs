using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace InputGlyphs.Display
{
    public static class DisplayUtils
    {
        public static bool CollectDevicesForControlScheme(InputControlScheme controlScheme, List<InputDevice> results, PlayerInput playerInput = null)
        {
            var pickResult = playerInput != null ? controlScheme.PickDevicesFrom(playerInput.devices) : default;
            if (!pickResult.isSuccessfulMatch)
            {
                pickResult = controlScheme.PickDevicesFrom(InputSystem.devices);
            }

            foreach (var device in pickResult.devices)
            {
                results.Add(device);
            }

            return pickResult.isSuccessfulMatch;
            ;
        }
    }
}
