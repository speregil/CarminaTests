using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace brewery.framework.ui {
    public class UIManager : MonoBehaviour
    {
        [Header("UI Fields")]
        [SerializeField] private GameObject healthField;

        [Header("Fields Options")]
        [SerializeField] private Color highHealthColor;
        [SerializeField] private Color midHealthColor;
        [SerializeField] private Color lowHealthColor;
        [SerializeField] private float highTreshold;
        [SerializeField] private float midTreshold;

        private Text healthText;
        private Image healthBar;

        private int currentHealth;
        private int maxHealth;
        void Start(){
            healthText = healthField.GetComponentInChildren<Text>();
            healthBar = healthField.GetComponentInChildren<Image>();
            currentHealth = 0;
            maxHealth = 0;    
        }

        public void UpdateCurrentHealth(int value) {
            currentHealth = value;
            healthText.text = currentHealth.ToString();
            if(currentHealth >= maxHealth*highTreshold)
                healthBar.color = highHealthColor;
            else if(currentHealth >= maxHealth*midTreshold)
                healthBar.color = midHealthColor;
            else
                healthBar.color = lowHealthColor;
        }

        public void UpdateMaxHealth(int value) {
            maxHealth = value;
            int dif = maxHealth - currentHealth;
            UpdateCurrentHealth(currentHealth + dif);
        }
    }
}