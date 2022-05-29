using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    [SerializeField] 
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }
    void TalkedTo(Character_State talker)
    {   
        Debug.Log("You talked to me!");
        Debug.Log("I dont have anything to say, but I am flattered anyway");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
