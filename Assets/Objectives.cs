using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objectives: MonoBehaviour
{
    public TextMeshProUGUI _Objective;
    public int CurrentObjective;

    public bool doorOpen;
    
    public string title;
    public string description;

    public GameObject outerdoor;
    private KeySystem.KeyDoorController DoorScript;


    void Start()
    {
        
        DoorScript = outerdoor.GetComponent<KeySystem.KeyDoorController>();

        _Objective.text = "Find the key and open the front door";

    }


    private void Update()
    {
        if (DoorScript.doorOpen&& CurrentObjective==0)
        {
            doorOpen = true;
            _Objective.text = "Find the key to the basement and enter the basement";
            CurrentObjective = 1;
        }





    }
}
