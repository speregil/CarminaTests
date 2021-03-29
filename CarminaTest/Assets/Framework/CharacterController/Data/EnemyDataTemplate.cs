using UnityEngine;
using UnityEngine.UI;

namespace brewery.framework.character.data {
    
    [CreateAssetMenu(fileName = "New EnemyDataTemplate", menuName ="Brewery/Data/Create Enemy Data Template")]
    public class EnemyDataTemplate : ScriptableObject
    {
        ///----------------------------------------
        /// Character info
        ///----------------------------------------
        [SerializeField] private string name;
        [SerializeField] private Sprite portrait;

        ///----------------------------------------
        /// Stats
        ///----------------------------------------
        [SerializeField] private int level;
        [SerializeField] private int hp;
        [SerializeField] private int strenght;
        [SerializeField] private int agility;
        [SerializeField] private int focus;
        [SerializeField] private int constitution;

        ///----------------------------------------
        /// Essences
        ///----------------------------------------
        private int rageEssence;
        private int willEssence;
        private int faithEssence;
        private int lustEssence;
        private int instinctEssence;

        ///----------------------------------------
        /// Functions
        ///----------------------------------------
    }
}
