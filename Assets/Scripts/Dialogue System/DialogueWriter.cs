using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class DialogueWriter : MonoBehaviour{
    [System.Serializable]
    public struct Line{
        public string DisplayName;
        public string Character;
        public string Mood;
        public string Text;
        public float PrintTime;
        public Line(string displayName, string character, string mood, string text, float printTime){
            this.DisplayName = displayName;
            this.Character = character;
            this.Mood = mood;
            this.Text = text;
            this.PrintTime = printTime;
        }
    }
    
    public GameObject parentObject; //object to disable when dialogue is done
    public CharacterIndexer indexer; //The script that holds the index of all possible characters
    public TMP_Text displayName; //The TextMesh component of the GameObject that holds the name of the character speaking.
    public Animator portraitAnim; //The animator component of the portrait object.
    public TMP_Text dialogue; //The TextMesh component of the GameObject that is the text box.
    public GameObject bgImageObject; //The Image component of the background Panel
    private Image bgImage;
    public Line[] lines;
    private int currentLine = -1; //The current line being shown on screen
    private string textToPrint;
    private int textPointer = 0; //The next char to put in the dialogue box
    private float timer = 0;
    private bool printing = false;
    private LightsEvent lightsScript;
    private PlayerInput inputComp;
    public UnityEvent OnFinishDialogue;

    void Start(){
    }

    void OnEnable(){
        lightsScript = GameObject.Find("Global Light 2D").GetComponent<LightsEvent>();
        bgImage = bgImageObject.GetComponent<Image>();
        NextLine();
        GameObject player = GameObject.Find("Player");
        if (player != null){
            inputComp = player.GetComponentInChildren<PlayerInput>();
        }
        if (inputComp!= null){
            inputComp.SwitchCurrentActionMap("Frozen");
        }
    }

    void OnDisable(){
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null){
            inputComp = player.GetComponentInChildren<PlayerInput>();
        }
        if (inputComp!= null){
            inputComp.SwitchCurrentActionMap("Moving Around");;
        }
    }

    public void OnInput(){
        if (!printing){
            NextLine();
        }else{
            if (currentLine != 0){
                printing = false;
                dialogue.text = textToPrint; 
                portraitAnim.SetBool("Talking",false);
            }
        }
    }
    
    void NextLine(){
        currentLine++;
        if (currentLine < lines.Length) {
            //Change the Display name on the plate
            displayName.text = lines[currentLine].DisplayName;
            //Switch the character to the correct one
            //First we need to find  the correct animator component
            //We need the index that corresponds to the character
            int charIndex;
            for(charIndex = 0 ; charIndex < indexer.chars.Length ; charIndex++){
                if (indexer.chars[charIndex].Name == lines[currentLine].Character){
                    break;
                }
            }
            if (charIndex == indexer.chars.Length){
                Debug.Log("The character " + lines[currentLine].Character + " hasn't been found (is it not on the index?)");
                parentObject.SetActive(false);
            }
            //we use that index to assign the correct background
            if(indexer.chars[charIndex].Bg != null) {
                //Sprite tex = indexer.chars[charIndex].Bg;
                bgImage.sprite = indexer.chars[charIndex].Bg;
                //bgImage.sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
            }
            //we use that index to assign the correct animator to the portrait
            portraitAnim.runtimeAnimatorController = indexer.chars[charIndex].Controller;
            //Next we send the right messages to the Animator component.
            //This means the mood, and whether the character is currently talking.
            portraitAnim.SetBool("Talking",true);
            //Send the current mood as a trigger to the animator
            portraitAnim.SetTrigger(lines[currentLine].Mood);
            //finally set up the printing of the line
            textToPrint = lines[currentLine].Text;
            dialogue.text = "";
            timer = 0;
            textPointer = 0;
            printing = true;
        }else{
            parentObject.SetActive(false);
            currentLine = -1;
            OnFinishDialogue?.Invoke();
        }
    }

    void Update(){
        if (printing){
            timer += Time.deltaTime;
            if (timer >= lines[currentLine].PrintTime){
                timer -= lines[currentLine].PrintTime;
                dialogue.text += textToPrint[textPointer]; 
                textPointer++;
                if (textPointer >= textToPrint.Length){
                    printing = false;
                    portraitAnim.SetBool("Talking",false);
                }
            }
        }
        portraitAnim.SetBool("Dark",!lightsScript.lights);
    }
}
