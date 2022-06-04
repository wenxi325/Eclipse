using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Item: ScriptableObject
{
//    private GameObject item;
   public string name;
   private int amount=1;
   private int order;

    public Item(string name,int amount,int order){
        this.name=name;
        this.amount=amount;
        this.order=order;
    }
   public string getName(){
       return this.name;
   }
    public int getAmount(){
        return this.amount;
    }
    public int getOrder(){
        return this.order;
    }
    public void setName(string tmpname){
        name=tmpname;
    }
    public void setAmount(int tmpamount){
        amount=tmpamount;
    }
    public void setOrder(int tmporder){
        order=tmporder;
    }
   


}
