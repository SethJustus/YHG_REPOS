using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int BaseFriendliness;
    public int PlayerFriendliness;
    public bool IsAFriend = false;
    public void Interaction()
    {
        bool positive  = true;
        if(positive == true)
        {
            BaseFriendliness += 1;
            PlayerFriendliness += BaseFriendliness + 10;
        }
    }

    public Character()
        {
            if(PlayerFriendliness > 100)
            {
                IsAFriend = true;
            }
        }
}
