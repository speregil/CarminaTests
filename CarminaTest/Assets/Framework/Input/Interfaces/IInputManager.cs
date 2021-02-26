using System;
using UnityEngine;

namespace brewery.framework.input {
    public interface IInputManager
    {
        void AddActionToBinding(string binding, Action action);
        float GetAxis(string axisName);
        bool GetButton(string buttonName);
        Vector2 GetMouseVector();
        void CheckForInput();
    }
}