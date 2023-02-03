using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    public AudioSource audioSrc;
    public float musicVolume = 1f;
    public Slider slider;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;
    }
    public void Mute()
    {
        musicVolume = 0f;
        slider.value = 0;
        //сохранение значение слайдера перед нажатием на муте
    }
    public void SetVolume()
    {
        musicVolume = slider.value;
    }
}
