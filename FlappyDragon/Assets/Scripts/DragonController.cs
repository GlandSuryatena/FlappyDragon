using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragonController : MonoBehaviour
{

Animator DragonAnimController;
 AudioSource myAudio;
    Rigidbody myBod;
   // bool Flap;

    Text gameOverTxt;
  Text scoreTxt;
    
  //  private bool gameOver;
 public AudioClip crash;
 public AudioClip flap;
public AudioClip point;

 private int score;

    // Start is called before the first frame update
    void Start()
    {
        myBod = GetComponent<Rigidbody>();
        myBod.velocity = new Vector3(10, 0, 0);
          myAudio = GetComponent<AudioSource>();
          DragonAnimController = GetComponent<Animator>();
        gameOverTxt = GameObject.Find("GameOver").GetComponent<Text>();
        scoreTxt = GameObject.Find("Score").GetComponent<Text>();
    //    gameOver = false;
    score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && Time.timeScale == 1){
myBod.velocity = new Vector3(10, 15, 0);
  myAudio.PlayOneShot(flap);
  DragonAnimController.SetBool("Flap",true);
         }
        if(Input.GetButtonDown("Jump") && Time.timeScale == 0){
        Time.timeScale = 1;

        SceneManager.LoadScene(0); // (re)load a scene.
         }
        if(!Input.GetButtonDown("Jump") && Time.timeScale == 1){
  DragonAnimController.SetBool("Flap",false);
         }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        //Do Stuff
        //camTran.position += new Vector3(0, 0, -10);
        myAudio.PlayOneShot(crash);
 Time.timeScale = 0;
      gameOverTxt.text = "Game Over \r\nPress Jump to Play Again";
//gameOver = true;
    }

     private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        //Do Stuff
      // if(otherGO.name == "Column"){
       
        myAudio.PlayOneShot(point);
score += 1;
        scoreTxt.text = "Score: " + score;
  //  }
    }
}