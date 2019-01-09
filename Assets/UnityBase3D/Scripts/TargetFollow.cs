using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace negitama.UnityBase3D
{
    public class TargetFollow : MonoBehaviour
    {
        [SerializeField] Transform target;

        private Vector3 offset;

        private void Start ()
        {
            if ( !TargetExists () ) return;

            offset = this.transform.position - target.position;
        }

        private void LateUpdate ()
        {
            if ( !TargetExists () ) return;

            this.transform.position = target.position + offset;
        }

        // targetの存在確認。targetがnullならスクリプトを無効化する
        private bool TargetExists ()
        {
            if ( target == null )
            {
                this.enabled = false;
                return false;
            }

            return true;
        }
    }
}
