using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace brewery.framework.input {
    public class InputManagement : IInputManager
    {
        protected InputBindings inputBindings;
        protected IMouseInputHandler mouseInputHandler;
        protected Dictionary<string, Action> actionMap = new Dictionary<string, Action>();

        public InputManagement(InputBindings inputBindings, IMouseInputHandler mouseInputHandler){
            this.inputBindings = inputBindings;
            this.mouseInputHandler = mouseInputHandler;
        }

        public void AddActionToBinding(string binding, Action action){
            actionMap.Add(binding, action);
        }

        public float GetAxis(string axisName){
            return Input.GetAxis(axisName);
        }

        public bool GetButton(string buttonName){
            return Input.GetButton(buttonName);
        }

        public Vector2 GetMouseVector(){
            return mouseInputHandler.GetInput();
        }

        public void CheckForInput(){
            foreach(var kvp in inputBindings.KeyBindings){
                if(Input.GetKeyDown(kvp.Value)){
                    Action action;
                    actionMap.TryGetValue(kvp.Key, out action);
                    if(action != null){
                        action.Invoke();
                    }
                }
            }
        }
    }
}