using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour
{

    public GameManager gameState;
    public Image background;

    public Sprite[] roomBackgrounds;

    public AudioClip[] gameBGM;

    public GameObject[] roomCanvasLayouts;

    public Fungus.Flowchart[] roomDialogues;

    int roomIDLastCheck;

    // Start is called before the first frame update
    void Start()
    {

        // generate room canvas
        int currentRoomID = (int)gameState.currentRoom;
        Instantiate(roomCanvasLayouts[currentRoomID]);

    }

    // Update is called once per frame
    void Update()
    {

        // set current roomBG
        int currentRoomID = (int) gameState.currentRoom;
        background.sprite = roomBackgrounds[currentRoomID];

        // run if change in current room ID
        if(currentRoomID != roomIDLastCheck)
        {
            Debug.Log("Player moving from room " + roomIDLastCheck + " to new room " + currentRoomID);

            roomIDLastCheck = currentRoomID;
        }

        if (!gameState.eventFlags[currentRoomID])
        {
            Debug.Log("Room " + currentRoomID + ": running first entry script");

            // set room's "visited" flag to true upon first entry
            gameState.eventFlags[currentRoomID] = true;
        }

    }
}
