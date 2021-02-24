using UnityEngine;

namespace brewery.framework.character.movement {
    public class MovementControls : MonoBehaviour {

        [Header("Data Templates")]
        [SerializeField] private CharacterDataTemplate characterDataTemplate;

        [Header("Other")]
        private InputManagement inputManager;

        void Start(){ }

        void FixedUpdate () {
            CheckForInput();
	    }

        private void CheckForInput()
        { }
    }
}