// 單行註解，不被程式執行，說明用途

// 引用 Unity 引擎的命名空間，函式庫，功能倉庫，開發遊戲功能
using UnityEngine;  // 這裡也可以加

// 腳本，程式稱為類別，定義物件的藍圖，例如：蓋房子的藍圖
// 藍圖轉為物件的方式
public class FirstScript : MonoBehaviour
{
    // 整理程式 Ctrl + K D
    // 縮排按鍵 Tab
    // 腳本內容

    // 事件：在特定時間點會執行的，名稱為藍色
    // 喚醒事件：播放遊戲時執行一次，初始處理
    private void Awake()
    {
        // 輸出(訊息)；
        print(777);
        print("哈囉，沃德 @3@");
    }

    // 開始事件：喚醒事件執行後才會執行開始事件一次
    private void Start()
    {
        print("<color=#662244>我在開始事件裡面</color>");

        // Ctrl + D 拷貝程式並換行
        print("字串內運算 10 + 7");
        print($"字串內運算 {10 + 7}");
    }

    // 更新事件：一秒約執行 60 次，約 60 FPS
    // 玩家的輸入偵測，例如：鍵盤、滑鼠、搖桿、觸控
    // 物件持續行為，例如：移動、旋轉、縮放
    private void Update()
    {
        print("<color=#ff0066>我是更新事件！</color>");
    }
}

// FirstScript 腳本外