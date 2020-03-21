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

    private AudioSource audioPlayer;

    public GameObject[] roomCanvasLayouts;
    private GameObject currentRoomCanvasLayout;

    public Fungus.Flowchart[] roomDialogues;

    int roomIDLastCheck;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = gameObject.GetComponent<AudioSource>();

        // generate room canvas
        int currentRoomID = (int)gameState.currentRoom;
        currentRoomCanvasLayout = Instantiate(roomCanvasLayouts[currentRoomID]);

    }

    // Update is called once per frame
    void Update()
    {

        // set current roomBG
        int currentRoomID = (int)gameState.currentRoom;
        background.sprite = roomBackgrounds[currentRoomID];

        // run if change in current room ID
        if (currentRoomID != roomIDLastCheck)
        {
            Debug.Log("Player moving from room " + roomIDLastCheck + " to new room " + currentRoomID);

            roomIDLastCheck = currentRoomID;


            // code on changing rooms

            GameManager.returnDestinations(currentRoomID);
            GameManager.RoomDestinations currentDestinations = GameManager.currentDestinationList;


            // Log current valid destinations

            Debug.Log("current exits: " + currentDestinations.doors[0] + "    " +
                currentDestinations.doors[1] + "    " +
                currentDestinations.doors[2] + "    " +
                currentDestinations.doors[3]);


            if (currentDestinations.doors[0] != 0)
            {
                NorthButton.gameObject.SetActive(true);
                NorthButton.interactable = true;
            } else
            {
                NorthButton.interactable = false;
                NorthButton.gameObject.SetActive(false);
            }

            if (currentDestinations.doors[1] != 0)
            {
                WestButton.gameObject.SetActive(true);
                WestButton.interactable = true;
            }
            else
            {
                WestButton.interactable = false;
                WestButton.gameObject.SetActive(false);

            }

            if (currentDestinations.doors[2] != 0)
            {
                EastButton.gameObject.SetActive(true);
                EastButton.interactable = true;
            }
            else
            {
                EastButton.interactable = false;
                EastButton.gameObject.SetActive(false);

            }

            if (currentDestinations.doors[3] != 0)
            {
                SouthButton.gameObject.SetActive(true);
                SouthButton.interactable = true;
            }
            else
            {
                SouthButton.interactable = false;
                SouthButton.gameObject.SetActive(false);

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



        // update Music

        if (currentRoomID > 10)
        {
            audioPlayer.clip = gameBGM[3];
            audioPlayer.Play();
        }


    }
}
