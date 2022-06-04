using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBar : MonoBehaviour
{
    // [SerializeField] private GameObject myBag;
    // List<Item> Items = new List<Item>();
    private bool isOpen=false;
    public bool IDcardGet=false;
    public bool Marry=false;
    public bool Bob =false;
    public bool John=false;
    public bool Fuller=false;
    public bool Selen=false;

    void Update()
    {
        if (Input.GetKeyDown("B"))
		{
            Debug.Log("Bag opened");
            Debug.Log("select 1:Marry, 2:Bob, 3:John, 4:Fuller, 5:Selen");
            //Toggle the opening of backpack.
            if(isOpen){
                isOpen=false;
            }
            else{
                isOpen=true;
            }
            
		}
    }


    public void gotIDcard()
    {
        IDcardGet=true;
        Marry =true;
        John=true;
        Bob=true;
        Fuller=true;
        Selen=true;
    }


}
