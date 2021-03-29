using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using brewery.framework.character.data;
using brewery.framework.ui;

namespace brewery.framework.character {
    
    /// <sumary>
    /// Controller for al the in-game data of the player
    /// </sumary>
    public class CharacterDataController : MonoBehaviour
    {
        ///---------------------------------------------------------------
        /// Fields
        ///---------------------------------------------------------------

        [SerializeField] private CharacterDataTemplate characterData;
        [SerializeField] private UIManager uiManager;

        private int currentHealth;

        ///---------------------------------------------------------------
        /// Functions
        ///---------------------------------------------------------------

        void Start() {
            initializeCharacter();
            uiManager.UpdateMaxHealth(currentHealth);
            uiManager.UpdateCurrentHealth(currentHealth);
        }

        private void initializeCharacter() {
            characterData.Data.hp = 100;
            currentHealth = characterData.Data.hp;
        }

        public void changeHealth(int changeValue) {
            currentHealth += changeValue;
            uiManager.UpdateCurrentHealth(currentHealth);
        }
    }
}