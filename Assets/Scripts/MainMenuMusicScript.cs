using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusicScript : MonoBehaviour
{
    public AudioSource BGM1;

    [SerializeField] private AudioClip bgm1;
    private AudioListener ad;
    

    private void Start(){
        BGM1.clip = bgm1;
        BGM1.Play();
        ad = GetComponent<AudioListener>();
    }
}
