using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人受傷系統
    /// </summary>
    public class DamageEnemy : DamageSystem
    {
        // 碰撞事件使用條件
        // 1. 兩個互相碰撞的物件都必須有 Collider 不限制形狀
        // 2. 其中必須有一個物件帶有 Rigidbody
        // 3-1. 如果兩個碰撞器都沒有勾 Is Trigger 就使用 Collision
        // 碰撞開始執行一次 Enter
        // 碰撞後持續執行　 Stay
        // 碰撞離開執行一次 Exit

        [SerializeField, Header("受傷音效")]
        private AudioClip soundDamage;

        private string nameMarble = "彈珠";

        // 將 DataBasic 轉為 DataEnemy 寫法
        // => Lambda 黏巴達符號
        private DataEnemy dataEnemy => (DataEnemy)data;

        private void OnCollisionEnter(Collision collision)
        {
            // print("碰到東西了!!!");

            if (collision.gameObject.name.Contains(nameMarble))
            {
                SoundSystem.instance.PlaySound(soundDamage);
                Damage(100);
            }
        }

        private void OnCollisionStay(Collision collision)
        {
            
        }

        private void OnCollisionExit(Collision collision)
        {
            
        }

        // 3-2. 如果兩個碰撞器其中一個有勾 Is Trigger 就使用 Trigger
        private void OnTriggerEnter(Collider other)
        {
            
        }

        // override 複寫：複寫父類別的成員
        protected override void Dead()
        {
            base.Dead();

            DropCoin();
            Destroy(gameObject);
        }

        /// <summary>
        /// 掉落金幣
        /// </summary>
        private void DropCoin()
        {
            // 隨機值： 0 ~ 1
            float random = Random.value;

            // print("機率：" + random);

            // 如果 隨機值 小於等於 敵人資料的金幣掉落機率 就生成金幣
            if (random <= dataEnemy.coinProbability)
            {
                // 生成 敵人資料金幣數量 的 金幣
                for (int i = 0; i < dataEnemy.coinCount; i++)
                {
                    Instantiate(
                        dataEnemy.prefabCoin,
                        transform.position + new Vector3(0, 1.5f, 0),
                        Quaternion.Euler(90, Random.Range(0, 360), 0));
                }
            }
        }
    }
}
