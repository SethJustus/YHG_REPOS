using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool tryingToTalk;
    void Update()
    {
        if(Input.GetAxis("Submit")==1&&tryingToTalk == false)
        {
            tryingToTalk = true;
            //Debug.Log("Trying to talk");
        }else{
            tryingToTalk = false;
            //Debug.Log("No longer trying");
        }
    }
}
