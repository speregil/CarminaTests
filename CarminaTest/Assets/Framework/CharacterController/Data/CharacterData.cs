using System;
using UnityEngine;

namespace brewery.framework.character.data {
    
    [Serializable] public class CharacterData
    {
        ///----------------------------------------
        /// Character info
        ///----------------------------------------
        public string name { get; set; }

        ///----------------------------------------
        /// Stats
        ///----------------------------------------
        public int level { get; set; }
        public int hp { get; set; }
        public int strenght { get; set; }
        public int agility { get; set; }
        public int focus { get; set; }
        public int constitution { get; set; }

        ///----------------------------------------
        /// Essences
        ///----------------------------------------
        public int rageEssence { get; set; }
        public int willEssence { get; set; }
        public int faithEssence { get; set; }
        public int lustEssence { get; set; }
        public int instinctEssence { get; set; }
    }
}