using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOScript : MonoBehaviour
{
    public void restart(){
        SceneManager.LoadScene(1);
    }

    public void menu(){
        SceneManager.LoadScene(0);
    }
}
