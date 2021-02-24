using UnityEngine;

namespace brewery.framework.input {
    public class DefaultBindings : InputBindings
    {
        protected override void SetupBindings()
        {
            base.SetupBindings();
            keyBindings.Add("forward", KeyCode.W);
            keyBindings.Add("back", KeyCode.S);
            keyBindings.Add("left", KeyCode.A);
            keyBindings.Add("right", KeyCode.D);
        }
    }
}