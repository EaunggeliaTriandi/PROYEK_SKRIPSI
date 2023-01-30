using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioClipController : MonoBehaviour
{
    public AudioClip[] _clipSource;
    public AudioSource BGM;

    void ChangeAudioIndex(int AudioIndex)
    {
        BGM.clip = _clipSource[AudioIndex];
    }
    public void NightBGM()
    {
        BGM.Stop();
        ChangeAudioIndex(1);
        BGM.Play();
    }
    public void DayBGM()
    {
        BGM.Stop();
        ChangeAudioIndex(0);
        BGM.Play();
    }
}
