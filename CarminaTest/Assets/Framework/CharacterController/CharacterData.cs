using System;
using UnityEngine;

namespace brewery.framework.character {
    [Serializable] 
    public class CharacterData
    {
        [Header("Movement")]
        [SerializeField] private float movementSpeed;

        public float MovementSpeed{
            get { return movementSpeed; }
        }
    }
}
