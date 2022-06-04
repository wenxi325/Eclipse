using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI; 

public class puzzleTrigger : MonoBehaviour
{
    public bool trigger;
    public Text caption;
    public GameObject Panel; 
  
    [SerializeField] private int puzzleID;
    private bool stopUpdate;

  
    public void PanelOpener() {  
        if (Panel != null) {  
            bool isActive = Panel.activeSelf;  
            Panel.SetActive(!isActive);  
        }  
    }  

    private void Awake(){
        trigger = false;
        Panel.SetActive(false);
        stopUpdate=false;

    }


     private void Update(){
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Time();
        }
        
    }
    private void Time(){
        if(trigger){
            caption.text="Time to solve Puzzle";
        }
    }

    private void checkTab(){
         if(Input.GetKeyDown(KeyCode.Tab)){
                stopUpdate=true;
                caption.text="Time to solve Puzzle";
            }
    }
    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            // stopUpdate=false;
            caption.text="Press Tab to solve for puzzle";
            trigger = true;
        }
        // Debug.Log(collider.gameObject.tag);


    }

    private void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            trigger = false;
        } 
        // Debug.Log("exit");       

    }


}
