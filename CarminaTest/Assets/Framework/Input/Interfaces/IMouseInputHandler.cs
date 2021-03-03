using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace brewery.framework.input {
    /// <sumary>
    /// Interface for any mouse handler
    /// </sumary>
    public interface IMouseInputHandler{
        
        /// <sumary>
        /// Returns the raw (x,y) screen position of the mouse
        /// </sumary>
        /// <return> Vector2 with the (x,y) screen position of the mouse </return>
        Vector2 GetRawPosition();

        /// <sumary>
        /// Returns an specific and procesed position of the mouse
        /// </sumary>
        /// <return> Vector2 with the specific (x,y) input of the mouse in a particular scenario </return>
        Vector2 GetInput();
    }
}