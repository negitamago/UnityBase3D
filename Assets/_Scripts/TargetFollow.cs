using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Negitama.UnityBase3D
{
    public class TargetFollow : MonoBehaviour
    {
        [SerializeField] Transform target;

        private Vector3 offset;

        private void Start ()
        {
            offset = this.transform.position - target.position;
        }

        private void LateUpdate ()
        {
            this.transform.position = target.position + offset;
        }
    }
}
