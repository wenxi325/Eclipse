using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
	List<Item> Items = new List<Item>();
    [SerializeField] private GameObject icon;
    public Text caption;
    public GameObject Panel; 
    private bool isOpen;
    void Awake(){
        Panel.SetActive(false);
        isOpen=false;
        caption.enabled=false;
    }

    public void addItem(Item Item){
        if(Items.IndexOf(Item) == -1){
            Items.Add(Item);
        }
    }

    public void deleteItem(Item Item){
        if(Items.IndexOf(Item) != -1){
             Items.Remove(Item);
        }
    }

    public void toggleBool(){
        if(isOpen){
            isOpen=false;
        }
        else{
            isOpen=true;
        }
    }
    void Update(){
            if(Input.GetKeyDown(KeyCode.B)){
                toggleBool();
                OpenBag();
        }
    }

    void OnMouseDown(){
        // Debug.Log("clicked");
        toggleBool();
        OpenBag();
    }

    private void OpenBag(){
        if(isOpen){
            Panel.SetActive(true);
            caption.enabled=true;
            string tmp="";
            if(Items.Count>0){
                foreach (Item tmpI in Items)
                {
                    tmp+= tmpI.getOrder().ToString() + ": " + tmpI.getName() + "("+tmpI.getAmount().ToString() + ") \n";
                }
                caption.text=tmp;
            }
        }
        else{
            Panel.SetActive(false);
            caption.enabled=false;
        }

    }
}
