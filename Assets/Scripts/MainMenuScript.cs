using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField]private GameObject o1;
    [SerializeField]private GameObject o2;
    [SerializeField]private GameObject o3;
    [SerializeField]private GameObject o4;
    [SerializeField]private GameObject o5;

    public void Update(){
        if(Input.GetKeyDown(KeyCode.Escape))
        exitAbout();
    }
    public void play(){
        SceneManager.LoadScene(1);
    }

    public void quit(){
        Application.Quit();
    }

    public void about(){
        o1.SetActive(false);
        o2.SetActive(false);
        o3.SetActive(false);
        o4.SetActive(true);
        o5.SetActive(false);
    }

    public void exitAbout(){
        o1.SetActive(true);
        o2.SetActive(true);
        o3.SetActive(true);
        o4.SetActive(false);
        o5.SetActive(true);
    }
}
