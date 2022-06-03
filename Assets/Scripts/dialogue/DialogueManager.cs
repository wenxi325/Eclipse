using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
//using UnityEngine.Input;
public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    [SerializeField] private GameObject nextButton;

    [Header("Choice UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;
    private bool dialogueIsPlaying;
    private static DialogueManager instance;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Found more than one DialogueManager");
        }
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }
    private void Start(){
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        //choices
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index ++;
        }
    }

    private void Update()
    {
        if(!dialogueIsPlaying)
        {
            return;
        }
        //RaycastHit2D hits2D = Physics2D.GetRayIntersection()
        
        if(Input.GetMouseButtonDown(1))
        {

            ContinueStory();



        }
        //OnMouseDown();
    }

    //  void OnMouseDown(){

    //     if(!dialogueIsPlaying)
    //     {
    //         return;
    //     }
    //     //RaycastHit2D hits2D = Physics2D.GetRayIntersection()
        
    //     if(instance.tag == "nextPate")
    //     {

    //         ContinueStory();



    //     }

    //  }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        ContinueStory();


    }
    private void ExitDialogueMode()
    {
        dialoguePanel.SetActive(false);
        dialogueIsPlaying = false;
        dialogueText.text = "";

    }

    private void ContinueStory()
    {
        if(currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();

        }
        else
        {
            ExitDialogueMode();
            Debug.Log("exit");
        }

    }

    // private void DisplayChoice()
    // {

    // }
}
