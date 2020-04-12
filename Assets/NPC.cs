using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NPC : MonoBehaviour
{

    public string dialogueName;

    private RoomManager roomManager;

    private Flowchart flowchart;

    private Sprite npcSprite;

    private bool activeNPC;

    // Start is called before the first frame update
    void Start()
    {

        GameObject flowchartObject = GameObject.Find("Flowchart");
        flowchart = flowchartObject.GetComponent<Flowchart>();

        roomManager = GameObject.Find("RoomManager").GetComponent<RoomManager>();

    }

    // Update is called once per frame
    void Update()
    {

        if (roomManager.currentBlockName.Equals("None"))
        {
            activeNPC = false;
        }

        if (activeNPC)
        {

            //npcSprite = gameObject.GetComponentInChildren<Sprite>();
            //npcSprite = roomManager.currentNPCSprite;

        }

    }

    public void speakToNPC()
    {
        Debug.Log("talking to NPC!");

        flowchart.ExecuteBlock(dialogueName);

        activeNPC = true;

    }
}
