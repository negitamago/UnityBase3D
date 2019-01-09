using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Negitama.UnityBase3D
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] float speed;

        private Rigidbody rb;

        private float inputH, inputV;

        private void Start ()
        {
            rb = GetComponent<Rigidbody> ();
        }

        private void Update ()
        {
            inputH = Input.GetAxis ( "Horizontal" );
            inputV = Input.GetAxis ( "Vertical" );
        }

        private void FixedUpdate ()
        {
            var moveValue = new Vector3 ( inputH, 0f, inputV ) * speed * Time.deltaTime;
            rb.MovePosition ( rb.position + moveValue );
        }
    }
}
