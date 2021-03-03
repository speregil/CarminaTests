using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace brewery.framework.input {
    
    /// <summary>
    /// Default implementation for the mous position input
    /// </sumary>
    public class DefaultMouseHandler : IMouseInputHandler
    {
        public DefaultMouseHandler(){}

        public Vector2 GetRawPosition(){
            return Input.mousePosition;
        }

        public Vector2 GetInput(){
            return Input.mousePosition;
        }
    }
}