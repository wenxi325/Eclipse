using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class IDCard: MonoBehaviour

{
    // [SerializeField] private GameObject card;

    // public Text caption;
    // public GameObject Panel; 

//    public bool avaliable = false;
    private bool isOpen=false;
    public bool IDcardGet=false;
    public bool Marry=false;
    public bool Bob =false;
    public bool John=false;
    public bool Fuller=false;
    public bool Selen=false;


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
