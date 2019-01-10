using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace negitama.UnityBase3D
{
    public class DestroyByContact : MonoBehaviour
    {
        [SerializeField] string otherTag;
        [SerializeField] float lifeTime;

        private void OnTriggerEnter ( Collider other )
        {
            if ( otherTag != string.Empty )
            {
                if ( !other.CompareTag ( otherTag ) ) return;
            }

            Destroy ( this.gameObject, lifeTime );
        }
    }
}
