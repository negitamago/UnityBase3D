using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace negitama.UnityBase3D
{
    public class ScoreText : MonoBehaviour
    {
        [SerializeField] PickupCount pickupCount;

        private Text text;

        private void Awake ()
        {
            pickupCount.PickedUp += ( sender, e ) => SetText ( e );
        }

        private void Start () => text = GetComponent<Text> ();

        private void SetText ( int score ) => text.text = $"Score: {score}";

        private void Update ()
        {
            if ( pickupCount != null ) return;

            Destroy ( this );
        }
    }
}
