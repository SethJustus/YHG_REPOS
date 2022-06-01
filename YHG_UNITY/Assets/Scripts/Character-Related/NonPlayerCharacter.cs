using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue_Manager manager;
    private GameObject playerGO;
    private Player player;
    public bool talking;
    
    public void TriggerDialogue()
    {
        manager.StartDialogue(dialogue);
    }
    public void EndDialogue()
    {
        manager.EndDialogue();
    }
    void Start()
    {
        playerGO = GameObject.Find("Player");
        player = playerGO.GetComponent<Player>();
        manager = FindObjectOfType<Dialogue_Manager>();

    }
    void Update()
    {
        float playerDistance = Vector2.Distance(player.transform.position, transform.position);
        if(playerDistance<2&&player.tryingToTalk == true)
        {
            if(talking == false)
            {
                TriggerDialogue();
                manager.NPC = this;
            }            
        }
        if(playerDistance>2)
        {
            this.talking = false;
        }
        if(talking == true)
        {
            if(playerDistance>2)
            {
                talking = false;
                //EndDialogue();
            }
        }
    }
}
