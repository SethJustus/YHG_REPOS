using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue_Manager : MonoBehaviour
{
    public NonPlayerCharacter NPC;
    private Queue<string> sentences;
    public GameObject display;
    public Text dialogueText;
    void Start()
    {
        sentences = new Queue<string>();
        
    }
    public void StartDialogue(Dialogue dialogue)
    {
        NPC.talking = true;
        display.SetActive(true);
        Debug.Log("You talked to "+dialogue.name);
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();        
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }
    public void EndDialogue()
    {
        NPC.talking = false;
        display.SetActive(false);
        Debug.Log("End of conversation");

    }
}
