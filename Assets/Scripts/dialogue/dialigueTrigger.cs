using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialigueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    private bool playerInRange;

    private void Awake(){
        playerInRange = false;

    }

    private void Update(){
        //Debug.Log(playerInRange);
        if(playerInRange)
        {
            if(Input.GetMouseButtonDown(0)){
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                Debug.Log("got here");

            }
            
        }
        else
        {
            

        }
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            playerInRange = true;
        }
        Debug.Log(collider.gameObject.tag);   


    }

    private void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            playerInRange = false;
        } 
        Debug.Log("exit");       

    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if( collision.gameObject.tag == "Player")
    //     {
    //         //Debug.Log(collision);
    //         playerInRange = true;
    //     }

    //     //changeScene();
    // }
    // private void OnCollisionExit2D(Collision2D collision)
    // {
    //     //Debug.Log(collision);
    //     playerInRange = false;

    //     //changeScene();
    // }    


  

}
