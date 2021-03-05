using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using brewery.framework.character.data;
using brewery.framework.ui;

namespace brewery.framework.character {
    public class DataController : MonoBehaviour
    {
        [SerializeField] private CharacterDataTemplate characterData;
        [SerializeField] private UIManager uiManager;

        private int currentHealth;

        void Start() {
            initializeCharacter();
            uiManager.UpdateMaxHealth(currentHealth);
            uiManager.UpdateCurrentHealth(currentHealth);
        }

        private void initializeCharacter() {
            characterData.Data.hp = 100;
            currentHealth = characterData.Data.hp;
        }
    }
}