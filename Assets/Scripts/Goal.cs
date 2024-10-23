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
            // ��ʼЭ�̣�������Ƶ���ټ��س���
            StartCoroutine(PlayAudioAndLoadScene());
        }
    }

    IEnumerator PlayAudioAndLoadScene()
    {
        // ������Ƶ
        if (!exitAudio.isPlaying)
        {
            exitAudio.Play();
        }
        // �ȴ���Ƶ�������
        yield return new WaitForSeconds(exitAudio.clip.length);

        // �����µĳ���
        SceneManager.LoadScene("main");
    }
}
