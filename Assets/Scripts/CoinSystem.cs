using UnityEngine;
using TMPro;

namespace KID
{
    /// <summary>
    /// 金幣系統
    /// </summary>
    public class CoinSystem : MonoBehaviour
    {
        private int coin;
        private TextMeshProUGUI textCoin;

        [SerializeField, Header("金幣音效")]
        private AudioClip soundCoin;

        private void Awake()
        {
            textCoin = GameObject.Find("文字金幣數量").GetComponent<TextMeshProUGUI>();
        }

        /// <summary>
        /// 更新金幣
        /// </summary>
        public void UpdateCoin()
        {
            // 金幣數量更新與介面更新
            coin++;
            textCoin.text = coin.ToString();
            SoundSystem.instance.PlaySound(soundCoin);
        }
    }
}
