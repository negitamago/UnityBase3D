using UnityEngine;
using UnityEditor;
using static UnityEditorInternal.InternalEditorUtility;
using static UnityEngine.LayerMask;

namespace negitama.UnityBase3D
{
    /// <summary>
    /// [エディター拡張] Layer Collision Matrix のチェックをすべてクリアする (Physics / Physics2D)
    /// 解説記事　http://negi-lab.blog.jp/archives/clear_layerCollisionMatrix.html
    /// </summary>
    public class ClearLayerCollisionMatrix : MonoBehaviour
    {
        [MenuItem ( "Tools/Clear_LayerCollisionMatrix" )]
        private static void Clear3D () => ClearMatrix ( false );

        [MenuItem ( "Tools/Clear_LayerCollisionMatrix2D" )]
        private static void Clear2D () => ClearMatrix ( true );

        private static void ClearMatrix ( bool isPhysics2d )
        {
            if ( !Confirm ( isPhysics2d ) ) return;

            foreach ( var layer1 in layers )
            {
                foreach ( var layer2 in layers )
                {
                    if ( isPhysics2d )
                    {
                        Physics2D.IgnoreLayerCollision ( NameToLayer ( layer1 ), NameToLayer ( layer2 ), true );
                    }
                    else
                    {
                        Physics.IgnoreLayerCollision ( NameToLayer ( layer1 ), NameToLayer ( layer2 ), true );
                    }
                }
            }
        }

        private static bool Confirm ( bool isPhysics2d )
        {
            var type = isPhysics2d ? "Physics 2D" : "Physics";

            return EditorUtility.DisplayDialog ( "Warning!",
                type + "\nLayerCollisionMatrixの設定をすべてクリアします" +
                "\n※実行後は元に戻せません", "OK", "Cancel" );
        }
    }
}
