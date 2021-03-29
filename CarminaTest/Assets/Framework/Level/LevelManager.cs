using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using brewery.framework.character;

namespace brewery.framework.level {
    /// <sumary>
    /// Controller for level-wide events and functionalities
    /// </sumary>
    [RequireComponent(typeof(BattleManager))]
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private int tileDamage;
        [SerializeField] private float levelBattleChance;
        [SerializeField] private float battleChanceStepMod;

        private CharacterDataController playerDataController;
        private BattleManager battleManager;
        private float currentBattleChance;

        void Start(){
            playerDataController = player.GetComponent<CharacterDataController>();
            battleManager = gameObject.GetComponent<BattleManager>();
            currentBattleChance = levelBattleChance;
        }

        public void generateTileDamage() {
            playerDataController.changeHealth(tileDamage*-1);        
        }

        public void checkBattleChance() {
            Debug.Log(currentBattleChance);
            float randomCheck = Random.Range(0.0f, 1.0f);
            if(randomCheck <= currentBattleChance)
                launchBattle();
            currentBattleChance+= battleChanceStepMod;
        }

        public void launchBattle() {
            currentBattleChance = levelBattleChance;
            battleManager.InitiateBattle();
        }
    }
}