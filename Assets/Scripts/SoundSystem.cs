using UnityEngine;

namespace KID
{
    /// <summary>
    /// 音效系統
    /// </summary>
    /// RequireComponent 要求元件，在第一次套用腳本到物件時會添加 () 內的元件
    [RequireComponent(typeof(AudioSource))]
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource aud;

        // 音效系統靜態資料
        public static SoundSystem instance;

        private void Awake()
        {
            // 將此物件存放在靜態資料內
            instance = this;
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound">想要播放的音效</param>
        public void PlaySound(AudioClip sound)
        {
            // 音源.播放一次音效(音效)
            aud.PlayOneShot(sound);
        }
    }
}
