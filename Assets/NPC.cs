using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NPC : MonoBehaviour
{

    public string dialogueName;

    private Flowchart flowchart;

    // Start is called before the first frame update
    void Start()
    {

        GameObject flowchartObject = GameObject.Find("Flowchart");
        flowchart = flowchartObject.GetComponent<Flowchart>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void speakToNPC()
    {
        Debug.Log("talking to NPC!");

        flowchart.ExecuteBlock(dialogueName);

    }
}
