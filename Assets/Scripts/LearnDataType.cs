using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習 Unity 資料類型
    /// Unity 開發遊戲常用的資料類型
    /// </summary>
    public class LearnDataType : MonoBehaviour
    {
        // 語法：
        // 修飾詞 資料類型 欄位名稱 指定 預設值；

        #region 顏色與座標
        // 顏色與座標 Color & Vector
        [Header("顏色")]
        public Color color1;

        public Color colorRed = Color.red;
        public Color colorYellow = Color.yellow;
        public Color colorGray = Color.gray;

        // Color(紅，綠，藍，透明度) - 0 ~ 1
        public Color colorCustom1 = new Color(0.5f, 0.5f, 0);
        public Color colorCustom2 = new Color(0, 0.5f, 0.5f, 0.5f);

        [Header("座標")]
        public Vector2 v2;
        public Vector3 v3;
        public Vector4 v4;

        public Vector2 v2One = Vector2.one;
        public Vector2 v2Custom = new Vector2(999, 1);
        #endregion

        [Header("資料")]
        // 資料
        public Sprite image;            // 圖片
        public AudioClip sound;         // 音樂、音效
        public Material mat;            // 材質球
        public GameObject prefab;       // 預製物
        public GameObject sceneObject;  // 場景上的物件
    }
}
