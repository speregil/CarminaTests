using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace brewery.framework.level {
    public class EventManager: MonoBehaviour
    {
        [SerializeField] private UnityEvent eventList;
        
        private void Start(){}

        private void OnTriggerEnter(Collider other)
        {
            invokeEvents();
        }

        private void invokeEvents() {
            eventList.Invoke();
        }
    }
}
