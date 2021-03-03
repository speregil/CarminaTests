using UnityEngine;

namespace brewery.framework.character {

    /// <sumary>
    /// Template for the info of a character in the game
    /// </sumary>
    [CreateAssetMenu(fileName = "New CharacterDataTemplate", menuName ="Brewery/Data/Create Character Data Template")]
    public class CharacterDataTemplate : ScriptableObject
    {
        [SerializeField]
        private CharacterData characterData;

        public CharacterData Data{
            get { return characterData; }
        }
    }
}