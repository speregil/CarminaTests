using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace brewery.framework.input {

    /// <sumary> 
    /// Superclass that defines a generic manager for Input Bindings
    /// </sumary>
    public class InputBindings
    {
        ///--------------------------------------------------
        /// Fields
        ///--------------------------------------------------

        /// <sumary> 
        /// Relates string identifiers with specific key codes
        /// </sumary>
        protected Dictionary<string, KeyCode> keyBindings = new Dictionary<string, KeyCode>();

        ///--------------------------------------------------
        /// Functions
        ///--------------------------------------------------

        /// <sumary> 
        /// Getter/Setter for the keyBindings
        /// </sumary>
        /// <return>keyBindigs dictionary</return>
        public Dictionary<string, KeyCode> KeyBindings{
            get { return keyBindings; }
        }

        /// <sumary> 
        /// Builds the bindigs based on the specific implementation of the class
        /// </sumary>
        public InputBindings(){
            SetupBindings();
        }

        /// <sumary> 
        /// Abstract function for particular implementation of bind pairings
        /// </sumary>
        protected virtual void SetupBindings(){}
    }
}