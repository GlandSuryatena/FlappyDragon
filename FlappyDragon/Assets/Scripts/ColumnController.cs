using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColumnController : MonoBehaviour
{
      
      
    // Start is called before the first frame update//
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        //Do Stuff
    //   if(otherGO.name == "Dragon"){
        GameObject g = Instantiate(gameObject); // makes a copy/clone of the connected game object.
        float f = Random.Range(0f,10f);
       float newX = g.GetComponent<Transform>().position.x + 40f;
        //make new column 40 units right of the previous column with a random Y between 0 and 10
       g.GetComponent<Transform>().position = new Vector3(newX,f,0);
      
        
      //  }//end of if statement
    }//end of trigger
}//end of script
