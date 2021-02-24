using UnityEngine;

namespace Test.RogueSmash {

    [CreateAssetMenu(fileName = "New CharacterDataTemplate", menuName ="RogueSmash/Data/Create Character Data Template")]
    public class CharacterDataTemplate : ScriptableObject
    {
        [SerializeField]
        private CharacterData characterData;

        public CharacterData Data{
            get { return characterData; }
        }
    }
}