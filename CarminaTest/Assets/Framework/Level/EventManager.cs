using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace brewery.framework.level.events {
    public class EventManager: MonoBehaviour
    {
        [SerializeField] private UnityEvent eventList;
        
        private void Start(){}

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Entró al piso");
            invokeEvents();
        }

        private void invokeEvents() {
            eventList.Invoke();
        }
    }
}
