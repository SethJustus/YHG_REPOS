using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    [SerializeField] 
    private GameObject playerGO;
    [SerializeField] 
    private Player player;
    private bool isTalking;
    // Start is called before the first frame update
    void Start()
    {
        playerGO = GameObject.Find("Player");
        player = playerGO.GetComponent<Player>();
        isTalking = false;

    }
    void TalkedTo(Player talker)
    {   
        if(isTalking == false)
        {
            Talking();
        }
    }
    void Talking()
    {
        isTalking = true;
        Debug.Log("I don't have a lot to say, but I am very flattered anyways");
        isTalking = false;
    }
    // Update is called once per frame
    void Update()
    {
        float playerDistance = Vector2.Distance(player.transform.position, transform.position);
        if(playerDistance<2&&player.tryingToTalk == true)
        {
            TalkedTo(player);
        }
    }
}
