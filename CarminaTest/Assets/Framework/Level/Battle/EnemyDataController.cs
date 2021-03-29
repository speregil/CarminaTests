using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using brewery.framework.character.data;
using brewery.framework.ui;

namespace brewery.framework.level {
    public class EnemyDataController : MonoBehaviour
    {
        ///---------------------------------------------------------------
        /// Fields
        ///---------------------------------------------------------------

        [SerializeField] private EnemyDataTemplate characterData;
        [SerializeField] private UIManager uiManager;

        private int currentHealth;

        ///---------------------------------------------------------------
        /// Functions
        ///---------------------------------------------------------------

        void Start() {
            initializeCharacter();
        }

        private void initializeCharacter() {}

        public void changeHealth(int changeValue) {
            currentHealth += changeValue;
        }
    }
}