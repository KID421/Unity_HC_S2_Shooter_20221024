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
        protected DataBasic data;
        [SerializeField, Header("血條")]
        private Image imgHp;
        [SerializeField, Header("畫布傷害值")]
        private GameObject prefabDamage;
        [SerializeField, Header("文字血量")]
        private TextMeshProUGUI textHp;
        [SerializeField, Header("動畫控制器")]
        private Animator ani;

        private float hp, hpMax;
        private string parDamage = "觸發受傷";

        protected virtual void Awake()
        {
            hp = data.hp;
            hpMax = hp;

            textHp.text = hp.ToString();

            // Damage(80);
            // Damage(80);
        }

        /// <summary>
        /// 受傷
        /// </summary>
        /// <param name="attck">接收到的攻擊力</param>
        public void Damage(float attck)
        {
            hp -= attck;
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / hpMax;
            ani.SetTrigger(parDamage);

            // transform.position 此物件的座標
            // Quaternion.Euler(0, 0, 0) 指定角度
            GameObject tempDamage = Instantiate(
                prefabDamage, 
                transform.position + new Vector3(0, 1, 0), 
                Quaternion.Euler(60, 0, 0));

            // transform.GetChild(編號) 取得子物件
            // GetComponent<元件>() 取得元件
            tempDamage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "-" + attck;

            if (hp <= 0) Dead();
        }

        // public    公開：所有類別都可存取
        // private   私人：只有此類別可存取
        // protected 保護：此類別與子類別可存取

        // virtual   虛擬：可被子類別複寫 override

        /// <summary>
        /// 死亡
        /// </summary>
        protected virtual void Dead()
        {
            hp = 0;
            textHp.text = hp.ToString();
        }
    }
}
