using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float ObstacleSpeed;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
        Invoke("death",4f);
    }
    private void Update(){
        move();
    }

    private void move(){
        float ObstacleSpeedRange = Random.Range(ObstacleSpeed-50,ObstacleSpeed+50);
        rb.velocity = new Vector2(0,-1)*ObstacleSpeedRange*Time.deltaTime;
    }

    private void death(){
        Destroy(gameObject);
    }
}
