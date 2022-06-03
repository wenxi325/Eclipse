using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Backpack

{
    //bools are true when items are in the backpack
    private bool IdCard = false;

    private bool Bottle = false;

    //provide interface that show current status of items(whether they are in backpack)

    public bool is_IdCard(){
        return IdCard;
    }

    public void set_IdCard(bool exist)
    {
        IdCard = exist;
    }

    //need to think how to show item icon in the ItemBar




}
