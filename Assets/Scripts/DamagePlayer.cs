using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 玩家
    /// </summary>
    public class DamagePlayer : DamageSystem
    {
        [SerializeField, Header("結束畫面底圖")]
        private CanvasGroup groupFinal;

        protected override void Dead()
        {
            // base 父類別原本的內容
            base.Dead();

            StartCoroutine(ShowFinal());
        }

        private IEnumerator ShowFinal()
        {
            // 結束畫面的透明度 +0.1 * 10 次
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            // 結束畫面互動與遮擋勾選
            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }
    }
}
