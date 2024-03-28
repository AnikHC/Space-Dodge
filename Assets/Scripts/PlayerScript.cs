using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float playerSpeed;
    private Animator anim;
    public float playerHealth;
    [SerializeField] private float InvincibleTime;
    [SerializeField] private GameObject explosion;
    [SerializeField] private GameObject GOScreen;
    private float timer = 10f;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update(){
        playerMove();
        death();
        timer += Time.deltaTime;
    }

    private void playerMove(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(horizontal,vertical).normalized*500*playerSpeed*Time.deltaTime;

        if(horizontal<0)
            anim.SetBool("left",true);
        else if(horizontal>0)
            anim.SetBool("right",true);
        else{
            anim.SetBool("left",false);
            anim.SetBool("right",false);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll){

        if(coll.gameObject.tag == "obstacle"&&timer>=InvincibleTime){
            playerHealth--;
            Debug.Log(playerHealth);
            timer = 0;
            anim.SetBool("damage",true);
            Invoke("deathAnim",InvincibleTime);
        }
    }        

    private void death(){
        
        if(playerHealth <=0){
            Instantiate(explosion,transform.position,transform.rotation);
            Destroy(gameObject);
            GOScreen.SetActive(true);
        }

    }

    private void deathAnim(){
        anim.SetBool("damage",false);
    }
}

