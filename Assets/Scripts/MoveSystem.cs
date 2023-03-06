using UnityEngine;

namespace KID
{
    /// <summary>
    /// 移動系統：敵人回合讓敵人往前移動
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動單位"), Range(0, 10)]
        private float moveDistance = 2;
    }
}
