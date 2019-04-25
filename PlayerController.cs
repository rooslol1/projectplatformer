using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour{

    public float playerSpeed;
    public float jumpSpeed;
    private Rigidbody2D rb;
    private bool isJumping;
    private float move;
    public GameObject Button, Text;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();

        Button.SetActive(false);
        Text.SetActive(false);
    }

    private void Update(){    
        //movement -1 of 1  
        move = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        if (move > 0){  
            //dit draai hem 180 graden
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (move < 0){   
            //dit draait hem niet of weer terug
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
         
        //hier jump je
        if (Input.GetButtonDown("Jump") && !isJumping){

            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJumping = true;
        }
    }
         //dit laat hem op de grond lopen of bewegen 
    private void OnCollisionEnter2D(Collision2D other){

       if (other.gameObject.CompareTag("Ground")){
            isJumping = false;
        }
    }
        //als je de spike raakt rest de game van af het begin
    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.tag== "spike"){

            Text.SetActive(true);
            Button.SetActive(true);
            gameObject.SetActive(false);

        }
    }


}
