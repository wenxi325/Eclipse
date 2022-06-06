using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI; 

public class CollectItem : MonoBehaviour
{
    public Inventory inventoryObject;
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
                CreateItem("IDcard", 5, 0);
                break;
            case 1:
                CreateItem("DeadBody",1,1);
                break;
            case 2:
                CreateItem("meteorite fragments",1,2);
                break;
            case 3:
                CreateItem("Plant", 1,3);
                break;
            case 4:
                CreateItem("Container",1,4);
                break;
            case 5:
                CreateItem("key",1,5);
                break;
            case 6:
                CreateItem("compass",1,6);
                break;
            case 7:
                CreateItem("crowbar",1,7);
                break;
            case 8:
                CreateItem("recorder",1,8);
                break;
            default:
                break;
        }

        }
    }
    private void CreateItem(string tmpname, int tmpAmount, int tmpOrder)
    {
        Item tmp = ScriptableObject.CreateInstance<Item>();
        tmp.setAmount(tmpAmount);
        tmp.setName(tmpname);
        tmp.setOrder(tmpOrder);
        Debug.Log(tmp.getName());
        inventoryObject = GameObject.FindObjectOfType(typeof(Inventory)) as Inventory;
        inventoryObject.addItem(tmp);
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
