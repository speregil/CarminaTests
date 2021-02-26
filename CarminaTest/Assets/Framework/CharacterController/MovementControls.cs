using UnityEngine;
using brewery.framework.input;

namespace brewery.framework.character.movement {
    public class MovementControls : MonoBehaviour {


        [Header("Controllers")]
        private IInputManager inputManager;
        [SerializeField] private GameObject frontAnchor;
        [SerializeField] private float stepDistance;

        void Start(){
            inputManager = new InputManagement(new DefaultBindings(),null);
            inputManager.AddActionToBinding("forward", MoveForward);
            inputManager.AddActionToBinding("back", MoveBack);
            inputManager.AddActionToBinding("left", MoveLeft);
            inputManager.AddActionToBinding("right", MoveRight);
         }

        void Update () {
            CheckForInput();
	    }

        private void CheckForInput(){ 
            inputManager.CheckForInput();
        }

        private void MoveForward() {
            DirectionalMovement("forward");
        }

        private void MoveBack() {
            DirectionalMovement("back");
        }

        private void MoveLeft() {
            DirectionalMovement("left");
        }

        private void MoveRight() {
            DirectionalMovement("right");
        }

        private void DirectionalMovement(string direction){
            Vector3 currentFront = frontAnchor.transform.localPosition;
            Debug.Log(currentFront);
            Vector3 forward;
            switch (direction){
                case "forward":
                    forward = Vector3.Scale(currentFront,new Vector3(stepDistance,0,stepDistance));
                    MoveCharacter(forward);
                    break;
                case "back":
                    forward = Vector3.Scale(currentFront,new Vector3(stepDistance*-1,0,stepDistance*-1));
                    MoveCharacter(forward);
                    break;
                case "right":
                    Vector3 rightVector = new Vector3(currentFront.z,currentFront.y,currentFront.x*-1);
                    frontAnchor.transform.localPosition = rightVector;
                    break;
                case "left":
                    Vector3 leftVector = new Vector3(currentFront.z*-1,currentFront.y,currentFront.x);
                    frontAnchor.transform.localPosition = leftVector;
                    break;
            }

        }

        private void MoveCharacter(Vector3 forward) {
            gameObject.transform.Translate(forward);
        }
    }
}