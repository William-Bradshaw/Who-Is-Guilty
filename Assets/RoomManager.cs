using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour
{

    public GameManager gameState;
    public Image background;

    public Lean.Gui.LeanButton NorthButton;
    public Lean.Gui.LeanButton WestButton;
    public Lean.Gui.LeanButton EastButton;
    public Lean.Gui.LeanButton SouthButton;

    public Sprite[] roomBackgrounds;

    public AudioClip[] gameBGM;

    public GameObject[] roomCanvasLayouts;
    private GameObject currentRoomCanvasLayout;

    public Fungus.Flowchart[] roomDialogues;

    int roomIDLastCheck;

    // Start is called before the first frame update
    void Start()
    {

        // generate room canvas
        int currentRoomID = (int)gameState.currentRoom;
        currentRoomCanvasLayout = Instantiate(roomCanvasLayouts[currentRoomID]);

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


            // code on changing rooms

            GameManager.RoomDestinations currentDestinations = GameManager.returnDestinations(currentRoomID);

            if(currentDestinations.doors[0] != 0)
            {
                NorthButton.interactable = true;
            } else
            {
                NorthButton.interactable = false;
            }

            if (currentDestinations.doors[1] != 0)
            {
                WestButton.interactable = true;
            }
            else
            {
                WestButton.interactable = false;
            }

            if (currentDestinations.doors[2] != 0)
            {
                EastButton.interactable = true;
            }
            else
            {
                EastButton.interactable = false;
            }

            if (currentDestinations.doors[3] != 0)
            {
                SouthButton.interactable = true;
            }
            else
            {
                SouthButton.interactable = false;
            }

        }

        if (!gameState.eventFlags[currentRoomID])
        {
            Debug.Log("Room " + currentRoomID + ": running first entry script");

            // set room's "visited" flag to true upon first entry
            gameState.eventFlags[currentRoomID] = true;
        }

        // change room canvas layout to match current room

        Destroy(currentRoomCanvasLayout);
        currentRoomCanvasLayout = Instantiate(roomCanvasLayouts[currentRoomID]);

    }
}
