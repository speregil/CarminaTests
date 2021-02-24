using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace brewery.framework.input {
    public interface IMouseInputHandler{
        Vector2 GetRawPosition();
        Vector2 GetInput();
    }
}