using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public AudioSource BGM;

    [SerializeField] private AudioClip bgm;
    private AudioListener ad;
    

    private void Start(){
        BGM.clip = bgm;
        BGM.Play();
        ad = GetComponent<AudioListener>();
    }
    private void Update(){
        
    }
    private void mute(){
        ad.enabled=!ad.enabled;
    }
}
