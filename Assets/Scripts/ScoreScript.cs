using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text scoreTextGO;
    [SerializeField] private Text HitPointsleft;
    [SerializeField] private GameObject player;
    [SerializeField] private Text hits;
    PlayerScript playerScript;
    private float score = 0f;
    private void Awake(){
        playerScript = player.GetComponent<PlayerScript>();
    }
    private void Update(){
        if(GameObject.FindGameObjectWithTag("Player") != null)
        score += 1 * Time.deltaTime;
        scoreText.text=((int)score).ToString();
        scoreTextGO.text=((int)score).ToString();
        hits.text=((int)playerScript.playerHealth).ToString();
    }
}
