using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue_Manager : MonoBehaviour
{
    public NonPlayerCharacter NPC;
    private Queue<string> sentences;
    private GameObject Player;
    private Character_State playerState;
    public GameObject display;
    public Text dialogueText;
    public bool displaying;
    void Start()
    {
        sentences = new Queue<string>();
        Player = GameObject.Find("Player");
        playerState = Player.GetComponent<Character_State>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        NPC.talking = true;
        playerState.talking = true;
        display.SetActive(true);
        Debug.Log("You talked to "+dialogue.name);
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();   
        displaying = true;     
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
        playerState.talking = false;
        NPC.talking = false;
        display.SetActive(false);
        Debug.Log("End of conversation");
        displaying = false;
    }
    void Update()
    {
        if(this.NPC.talking == false)
        {
            EndDialogue();
        }
    }
}