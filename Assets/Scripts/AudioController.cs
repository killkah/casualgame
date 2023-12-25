using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource musicMenu;
    public AudioSource soundButton;
    public AudioSource soundShoot;
    public Slider sliderVolume;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        musicMenu.volume = sliderVolume.value;
        soundButton.volume = sliderVolume.value;
        
    }
    public void SoundButton()
    {
        soundButton.Play();
    }
}
