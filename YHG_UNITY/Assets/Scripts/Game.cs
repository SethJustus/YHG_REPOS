using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private GameObject GetManager;
    public Dialogue_Manager Dialogue_Manager;
    public LayerMask ground;

    void Start()
    {
        GetManager = GameObject.FindGameObjectWithTag("Dialogue_Manager");
        Dialogue_Manager = GetManager.GetComponent<Dialogue_Manager>();
    }

}
