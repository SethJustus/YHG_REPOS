using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_NonPlayer : MonoBehaviour
{
    public Dialogue dialogue;
    public bool talking;
    private Canvas canvas;
    private Queue<string> sentences;
    
    void Start()
    {
        canvas = GetComponentInChildren<Canvas>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        
        // NPC.talking = true;
        // playerState.talking = true;
        // display.SetActive(true);
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();   
        //displaying = true;     
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        //dialogueText.text = sentence;
        Debug.Log(sentence);
    }
    public void EndDialogue()
    {
        // playerState.talking = false;
        // NPC.talking = false;
        // display.SetActive(false);
        // displaying = false;
    }
}
