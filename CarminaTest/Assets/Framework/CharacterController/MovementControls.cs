using UnityEngine;
using brewery.framework.input;

namespace brewery.framework.character.movement {
    public class MovementControls : MonoBehaviour {

        private IInputManager inputManager;

        [Header("Required Objects")]
        [SerializeField] private GameObject frontAnchor;
        [SerializeField] private GameObject mainCamera;
        private AudioSource wallHit;

        [Header("Movement Parameters")]
        [SerializeField] private float moveDistance;
        [SerializeField] private float stepSpeed;
        [SerializeField] private float rotationSpeed;
        [SerializeField] private float stepMarginError;
        [SerializeField] private float rotationMarginError;

        private bool isMoving;
        private bool isRotating;
        private Vector3 currentDestination;
        private Vector3 currentFaceTarget;

        void Start(){
            inputManager = new InputManagement(new DefaultBindings(), new DefaultMouseHandler());
            inputManager.AddActionToBinding("forward", MoveForward);
            inputManager.AddActionToBinding("back", MoveBack);
            inputManager.AddActionToBinding("left", MoveLeft);
            inputManager.AddActionToBinding("right", MoveRight);

            wallHit = GetComponent<AudioSource>();

            isMoving = false;
            isRotating = false;
            currentDestination = new Vector3(0,1,0);
         }

        void Update () {
            if(isMoving)
                MoveCharacter();
            if(isRotating)
                RotateCamera();
            if (!(isMoving || isRotating))
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
            Vector3 currentPos = gameObject.transform.localPosition;
            Vector3 newDirection;
            switch (direction){
                case "forward":
                    if(!checkObstacle(1)){
                        newDirection = Vector3.Scale(currentFront,new Vector3(moveDistance,1,moveDistance));
                        currentDestination = new Vector3(currentPos.x+newDirection.x,1,currentPos.z+newDirection.z);
                        isMoving = true;
                    }
                    else
                        wallHit.Play();
                    break;
                case "back":
                    if(!checkObstacle(-1)){
                        newDirection = Vector3.Scale(currentFront,new Vector3(moveDistance*-1,1,moveDistance*-1));
                        currentDestination = new Vector3(currentPos.x+newDirection.x,1,currentPos.z+newDirection.z);
                        isMoving = true;
                    }
                    else
                        print("pared");
                    break;
                case "right":
                    Vector3 rightVector = new Vector3(currentFront.z,currentFront.y,currentFront.x*-1);
                    frontAnchor.transform.localPosition = rightVector;
                    frontAnchor.transform.Rotate(0,90,0,Space.Self);
                    currentFaceTarget = frontAnchor.transform.forward;
                    mainCamera.transform.localPosition = frontAnchor.transform.localPosition;
                    isRotating = true;
                    break;
                case "left":
                    Vector3 leftVector = new Vector3(currentFront.z*-1,currentFront.y,currentFront.x);
                    frontAnchor.transform.localPosition = leftVector;
                    frontAnchor.transform.Rotate(0,-90,0,Space.Self);
                    currentFaceTarget = frontAnchor.transform.forward;
                    mainCamera.transform.localPosition = frontAnchor.transform.localPosition;
                    isRotating = true;
                    break;
            }
        }

        private bool checkObstacle(int faceDirection) {
            return Physics.Raycast(frontAnchor.transform.position, frontAnchor.transform.TransformDirection(Vector3.forward*faceDirection), moveDistance/2 + 1);
        }

        private void MoveCharacter() {
            Vector3 currentPos = gameObject.transform.localPosition;
            float posChange = stepSpeed*Time.deltaTime;
            Vector3 newPos = Vector3.MoveTowards(currentPos, currentDestination, posChange);
            gameObject.transform.localPosition = newPos;
            if (Vector3.Distance(gameObject.transform.localPosition, currentDestination) < stepMarginError){
                gameObject.transform.localPosition = currentDestination;
                isMoving = false;
            }
        }
        private void RotateCamera() {
            Vector3 currentFacing = mainCamera.transform.forward;
            Vector3 newDirection = Vector3.RotateTowards(currentFacing, currentFaceTarget, rotationSpeed*Time.deltaTime, 0.0f);
            mainCamera.transform.localRotation = Quaternion.LookRotation(newDirection);
            if (Vector3.Distance(mainCamera.transform.forward, frontAnchor.transform.forward) < rotationMarginError){
                mainCamera.transform.localRotation = frontAnchor.transform.localRotation;
                isRotating = false;
            }
        }
    }
}