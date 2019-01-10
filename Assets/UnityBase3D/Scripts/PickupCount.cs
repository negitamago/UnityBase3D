using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace negitama.UnityBase3D
{
    public class PickupCount : MonoBehaviour
    {
        [SerializeField] string pickupTag;

        public EventHandler<int> PickedUp;
        public int score;

        private void Start () => score = 0;

        private void OnTriggerEnter ( Collider other )
        {
            if ( !other.CompareTag ( pickupTag ) ) return;

            score++;

            PickedUp ( this, score );
        }
    }
}
