using UnityEngine;

namespace brewery.framework.character.data {

    /// <sumary>
    /// Template for the info of a character in the game
    /// </sumary>
    [CreateAssetMenu(fileName = "New CharacterDataTemplate", menuName ="Brewery/Data/Create Character Data Template")]
    public class CharacterDataTemplate : ScriptableObject
    {
        ///-----------------------------------------------------------
        /// Fields
        ///-----------------------------------------------------------

        /// <sumary> Data field of the character </sumary>
        [SerializeField]private CharacterData characterData;

        ///-----------------------------------------------------------
        /// Functions
        ///-----------------------------------------------------------

        /// <sumary> Returns the characterData object </sumary>
        /// <return> CharacterData object </return>
        public CharacterData Data{
            get { return characterData; }
        }
    }
}