using UnityEngine;

namespace brewery.framework.character {

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