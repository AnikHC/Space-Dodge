using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class PMScript : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject music;
    private AudioSource bgmM;
    private bool isPaused = false;
    MusicScript musicScript;
    

private void Start(){
    pauseMenu.SetActive(false);
    musicScript = music.GetComponent<MusicScript>();
    bgmM = musicScript.GetComponent<AudioSource>();
}
    private void Update(){
        esc();
    }

    private void esc(){
        if(Input.GetKeyDown(KeyCode.Escape)&&isPaused==false){
        pause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape)&&isPaused==true){
        resume();
        }
        
    }
    private void pause(){
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        isPaused = true;
        Debug.Log("Pause");
        bgmM.Pause();
    }

    public void resume(){
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        isPaused = false;
        Debug.Log("Resume");
        bgmM.Play();
    }

    public void menu(){
        SceneManager.LoadScene(0);
        Time.timeScale=1f;
    }

    private void mute(){
        if(music == true)
        music.SetActive(false);

        if(music == false)
        music.SetActive(true);
    }
}
