using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public AudioSource exitAudio;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            // 开始协程，播放音频后再加载场景
            StartCoroutine(PlayAudioAndLoadScene());
        }
    }

    IEnumerator PlayAudioAndLoadScene()
    {
        // 播放音频
        if (!exitAudio.isPlaying)
        {
            exitAudio.Play();
        }
        // 等待音频播放完毕
        yield return new WaitForSeconds(exitAudio.clip.length);

        // 加载新的场景
        SceneManager.LoadScene("main");
    }
}
