using System;
using UnityEngine;

namespace brewery.framework.input {
    /// <sumary>
    /// Interface for any manager for input control and input bindings
    /// </sumary>
    public interface IInputManager
    {
        /// <sumary> 
        /// Creates a new entry for a binding-action pair
        /// </sumary>
        /// <param  name="binding">Name of the new binding</param>
        /// <param name="action">Existing Action function to call asociated with the binding</param>
        void AddActionToBinding(string binding, Action action);

        /// <sumary> 
        /// Returns the value of the current input axis
        /// </sumary>
        /// <param  name="axisName">Name of the axis, vertical or horizontal</param>
        /// <return>Value of the current input axis</return>
        float GetAxis(string axisName);
        
        /// <sumary> 
        /// Verifies if the button with the given name was pressed the previous frame
        /// </sumary>
        /// <param  name="buttonName">Name of the button</param>
        /// <return>True if the button with the given name was pressen, false otherwise</return>
        bool GetButton(string buttonName);
        
        /// <sumary> 
        /// Returns the curent position vector of the mouse cursor
        /// </sumary>
        /// <return>A Vector2 with the (x,y) position on screen coordinates
        /// of the mouse cursor</return>
        Vector2 GetMouseVector();
        
        /// <sumary> 
        /// Veryfies all the input bindigs added to the current manager and invokes the
        /// corresponding actions
        /// </sumary>
        void CheckForInput();
    }
}