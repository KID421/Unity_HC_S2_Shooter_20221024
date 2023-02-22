using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人資料
    /// </summary>
    // : 後面指的是繼承的類別，繼承後會擁有該類別的資料
    [CreateAssetMenu(menuName = "KID/Data Enemy", fileName = "New Data Enemy")]
    public class DataEnemy : DataBasic
    {
        [Header("金幣物件")]
        public GameObject prefabCoin;
        [Header("金幣數量"), Range(0, 500)]
        public int coinCount;
        [Header("掉落機率"), Range(0f, 1f)]
        public float coinProbability;
    }
}
