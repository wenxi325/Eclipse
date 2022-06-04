// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;
// using Ink.Runtime;
//  using UnityEngine.UI;
// //using UnityEngine.Input;
// public class DialogueManager : MonoBehaviour
// {
//     [Header("Dialogue UI")]
//     [SerializeField] private GameObject dialoguePanel;
//     [SerializeField] private TextMeshProUGUI dialogueText;

//     [SerializeField] private GameObject nextButton;

//     public Button buttonPrefab;


//     [Header("Choice UI")]
//     [SerializeField] private GameObject[] choices;
//     private TextMeshProUGUI[] choicesText;
//     private int chooseEvent;

//     private Story currentStory;
//     private bool dialogueIsPlaying;
//     private static DialogueManager instance;

//     private void Awake()
//     {
//         if(instance != null)
//         {
//             Debug.LogWarning("Found more than one DialogueManager");
//         }
//         instance = this;
//     }

//     public static DialogueManager GetInstance()
//     {
//         return instance;
//     }
//     private void Start(){
//         dialogueIsPlaying = false;
//         dialoguePanel.SetActive(false);

//         //choices
//         choicesText = new TextMeshProUGUI[choices.Length];
//         int index = 0;
//         foreach(GameObject choice in choices)
//         {
//             choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
//             index ++;
//         }

        
//     }

//     private void Update()
//     {
//         if(!dialogueIsPlaying)
//         {
//             return;
//         }
//         //RaycastHit2D hits2D = Physics2D.GetRayIntersection()
        
//         if(Input.GetKeyDown(KeyCode.Space))
//         {

//             ContinueStory();



//         }
//         //OnMouseDown();
//     }

//     //  void OnMouseDown(){

//     //     if(!dialogueIsPlaying)
//     //     {
//     //         return;
//     //     }
//     //     //RaycastHit2D hits2D = Physics2D.GetRayIntersection()
        
//     //     if(instance.tag == "nextPate")
//     //     {

//     //         ContinueStory();



//     //     }

//     //  }

//     public void EnterDialogueMode(TextAsset inkJSON, int followUpEvent)
//     {
//         // Debug.Log("enter dialog");
//         // chooseEvent = followUpEvent;
//         currentStory = new Story(inkJSON.text);
//         // Debug.Log(currentStory.Continue());
//         dialogueIsPlaying = true;
//         dialoguePanel.SetActive(true);
//         ContinueStory();



//     }

//     void OnClickChoiceButton (Choice choice) {
// 		currentStory.ChooseChoiceIndex (choice.index);
// 		ContinueStory();
// 	}
//     private void ExitDialogueMode()
//     {
//         dialoguePanel.SetActive(false);
//         dialogueIsPlaying = false;
//         dialogueText.text = "";
//         Debug.Log("exitDialogueMode");
//         // Item.GetInstance().FollowUpevent();

//     }

//     Button CreateChoiceView (string text) {
//             // Creates the button from a prefab
//             Button choice = Instantiate (buttonPrefab) as Button;
//             choice.transform.SetParent (this.transform, false);
            
//             // Gets the text from the button prefab
//             Text choiceText = choice.GetComponentInChildren<Text> ();
//             choiceText.text = text;

//             // Make the button expand to fit the text
//             HorizontalLayoutGroup layoutGroup = choice.GetComponent <HorizontalLayoutGroup> ();
//             layoutGroup.childForceExpandHeight = false;

//             return choice;
//         }
//     private void ContinueStory()
//     {
//         // if(currentStory.canContinue)
//         // {
//         //     dialogueText.text = currentStory.Continue();
//         //     Debug.Log(dialogueText.text);

//         // }
//         // else
//         // {
//         //     ExitDialogueMode();
//         //     Debug.Log("exit");
//         // }

//           while (currentStory.canContinue) {
// 			// Continue gets the next line of the story
// 			dialogueText.text = currentStory.Continue();
// 			// This removes any white space from the text.
//             Debug.Log(dialogueText.text);
// 		}

//         // Display all the choices, if there are any!
// 		if(currentStory.currentChoices.Count > 0) {
// 			for (int i = 0; i < currentStory.currentChoices.Count; i++) {
// 				Choice choice = currentStory.currentChoices [i];
// 				Button button = CreateChoiceView (choice.text.Trim ());
// 				// Tell the button what to do when we press it
// 				button.onClick.AddListener (delegate {
// 					OnClickChoiceButton (choice);
// 				});
// 			}
// 		}

//         // foreach (Choice choice in currentStory.currentChoices)
//         // {
//         //     Button choiceButton = Instantiate(buttonPrefab) as Button;
//         //     choiceButton.transform.SetParent(this.transform, false);
//         //     // Gets the text from the button prefab
//         //     Text choiceText = choiceButton.GetComponentInChildren<Text>();
//         //     choiceText.text = choice.text;
//         //     // Set listener
//         //     choiceButton.onClick.AddListener(delegate {
//         //     OnClickChoiceButton(choice);
//         //                 });
//         // }
        
        

//     }

//     // private void DisplayChoice()
//     // {

//     // }
// }
