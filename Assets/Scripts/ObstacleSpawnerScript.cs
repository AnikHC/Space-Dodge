using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject obstacle1;
    [SerializeField] private GameObject obstacle2;
    private float timer = 0f;
    [SerializeField] private float spawnTime;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    private float spawnD = 0f; 

    

    private void Update(){
        spawn();
        spawnDec();
    }
    private void spawn(){
        timer += Time.deltaTime;
        int obstacle = Random.Range(0,2);
        if(timer >= spawnTime){
            float spawnRange = Random.Range(minX,maxX);
            if(obstacle == 1)
                Instantiate(obstacle1,transform.position+new Vector3(spawnRange,0,0),transform.rotation);
            else
                Instantiate(obstacle2,transform.position+new Vector3(spawnRange,0,0),transform.rotation);
            timer = 0;
        }
    }

    private void spawnDec(){
        if(spawnTime >=0.26f){
            spawnD += Time.deltaTime;
            if(spawnD >= 10){
                spawnTime = spawnTime - 0.025f;
                Debug.Log(spawnTime);
                spawnD =0f;
            }
        }
    }
}
