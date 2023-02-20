using UnityEngine;

namespace KID
{
    /// <summary>
    /// 基本資料：血量與攻擊
    /// </summary>
    [CreateAssetMenu(menuName = "KID/Data Basic", fileName = "New Data Basic")]
    public class DataBasic : ScriptableObject
    {
        [Header("血量"), Range(1, 5000)]
        public float hp;
        [Header("攻擊力"), Range(1, 5000)]
        public float attack;
    }
}
