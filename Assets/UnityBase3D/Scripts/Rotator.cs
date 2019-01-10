using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace negitama.UnityBase3D
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] Vector3 rotateSpeed;

        private Rigidbody rb;

        private void Start () => rb = GetComponent<Rigidbody> ();

        private void FixedUpdate ()
        {
            var rot = Quaternion.Euler(rotateSpeed * Time.time);
            rb.MoveRotation ( rot );
        }
    }
}
