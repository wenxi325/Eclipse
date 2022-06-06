using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI; 

public class CollectItem : MonoBehaviour
{
    public Inventory inventoryObject;
    // public dialigueTrigger dialog;
    public bool trigger;
    public Text caption;
    public GameObject Panel; 
  
    [SerializeField] private int puzzleID;

  
    public void PanelOpener() {  
        if (Panel != null) {  
            bool isActive = Panel.activeSelf;  
            Panel.SetActive(!isActive);  
        }  
    }  

    private void Awake(){
        trigger = false;
        Panel.SetActive(false);
        caption.enabled=false;

    }

    private void Update(){
            if(Input.GetKeyDown(KeyCode.C)){
            collect();
            }
    }

    private void collect(){
        if(trigger){
              switch(puzzleID){
            case 0:
                Item tmp = ScriptableObject.CreateInstance<Item>();
                tmp.setAmount(5);
                tmp.setName("IDCard");
                tmp.setOrder(0);
                Debug.Log(tmp.getName());
                inventoryObject = GameObject.FindObjectOfType(typeof(Inventory)) as Inventory;
                inventoryObject.addItem(tmp);
                break;
            default:
                break;
        }

        }
      
    }
    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            trigger = true;
                caption.enabled=true;
                caption.text="press C to collect items";
                Panel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            trigger = false;
            caption.enabled=false;
            Panel.SetActive(false);
        }   
    }
}
