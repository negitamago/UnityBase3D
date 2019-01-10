using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace negitama.UnityBase3D
{
    public class DestroyByTime : MonoBehaviour
    {
        [SerializeField] float lifeTime;

        private void Start () => Destroy ( this.gameObject, lifeTime );
    }
}
