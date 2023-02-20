using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 受傷系統
    /// 受到傷害、執行動畫、彈出傷害值、死亡處理
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("基本資料")]
        private DataBasic data;
        [SerializeField, Header("血條")]
        private Image imgHp;
        [SerializeField, Header("畫布傷害值")]
        private GameObject prefabDamage;
        [SerializeField, Header("文字血量")]
        private TextMeshProUGUI textHp;

        private float hp, hpMax;

        private void Awake()
        {
            hp = data.hp;
            hpMax = hp;

            textHp.text = hp.ToString();
        }
    }
}
