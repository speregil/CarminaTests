using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace brewery.framework.input {
    public class RadialMouseInputHandler : IMouseInputHandler
    {
        
        private GameObject actor;

        public RadialMouseInputHandler(GameObject actor){
            this.actor = actor;
        }

        public Vector2 GetRawPosition(){
            return Input.mousePosition;
        }

        public Vector2 GetInput(){
            Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (actor.transform.position);
            Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(GetRawPosition());
            float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
            Quaternion rotation =  Quaternion.AngleAxis(angle, Vector3.up);
            return rotation.eulerAngles;
        }

        private float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
            return (Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg * -1) - 90.0f;
        }

    }
}
