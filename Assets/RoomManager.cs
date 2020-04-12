using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class RoomManager : MonoBehaviour
{
    public string currentBlockName;

    public Flowchart gameFlowchart;
    public Character currentCharacter;

    public Stage fungusStage;

    public Sprite currentNPCSprite;
    
    private Block[] currentBlocks;

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

    int currentSongPlaying;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = gameObject.GetComponent<AudioSource>();

        // generate room canvas
        int currentRoomID = (int)gameState.currentRoom;
        currentRoomCanvasLayout = Instantiate(roomCanvasLayouts[currentRoomID]);

    }

    // update NPC expressions
    void NPCUpdate()
    {

        if (gameFlowchart.gameObject.GetComponents<Block>().Length != 0)
        {

            Block executingBlock;

            currentBlocks = gameFlowchart.GetComponents<Block>();

            for (int i = 0; i < currentBlocks.Length; i++)
            {

                if (currentBlocks[i].IsExecuting())
                {

                    executingBlock = currentBlocks[i];

                    currentBlockName = executingBlock.name;

                }

            }

        } else
        {
            currentBlockName = "NONE";
        }

        List<Character> characterList = Stage.GetActiveStage().CharactersOnStage;

        currentNPCSprite = characterList[0].ProfileSprite; 


    }

    // Update is called once per frame
    void Update()
    {

        //NPCUpdate();

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


            if (!gameState.eventFlags[currentRoomID])
            {
                Debug.Log("Room " + currentRoomID + ": running first entry script");

                // set room's "visited" flag to true upon first entry
                gameState.eventFlags[currentRoomID] = true;
            }

            // change room canvas layout to match current room

            Destroy(currentRoomCanvasLayout);
            currentRoomCanvasLayout = Instantiate(roomCanvasLayouts[currentRoomID]);



            // update Music background track based on current room

            if (currentRoomID < 6)
            {
                if (currentSongPlaying != 2)
                {
                    // crime scene music (Sofia's Home)
                    audioPlayer.clip = gameBGM[2];
                    currentSongPlaying = 2;
                    audioPlayer.Play();
                }

            }
            else if (currentRoomID < 14)
            {
                if (currentSongPlaying != 4)
                {
                    // general indoor music
                    audioPlayer.clip = gameBGM[4];
                    currentSongPlaying = 4;
                    audioPlayer.Play();
                }

            }
            else if (currentRoomID < 24)
            {
                if (currentSongPlaying != 3)
                {
                    // general outdoor/town music
                    audioPlayer.clip = gameBGM[3];
                    currentSongPlaying = 3;
                    audioPlayer.Play();
                }
            }
            else if (currentRoomID < 32)
            {
                if (currentSongPlaying != 4)
                {
                    // general indoor music (for tower area)
                    audioPlayer.clip = gameBGM[4];
                    currentSongPlaying = 4;
                    audioPlayer.Play();
                }

            }
            else
            {
                if (currentSongPlaying != 5)
                {
                    // creepy music for final areas
                    audioPlayer.clip = gameBGM[5];
                    currentSongPlaying = 5;
                    audioPlayer.Play();
                }

            }


        }


    }

    public void setupMrDavidsInterview()
    {
        gameState.currentRoom = (GameManager.Room)32;
    }

    public void setupLilyInterview()
    {
        gameState.currentRoom = (GameManager.Room)33;
    }

    public void setupOliverInterview()
    {
        gameState.currentRoom = (GameManager.Room)34;
    }

    public void setupMonicaInterview()
    {
        gameState.currentRoom = (GameManager.Room)35;
    }

    public void setupAgathaInterview()
    {
        gameState.currentRoom = (GameManager.Room)36;
    }

    public void setupEmptyInterviewRoom()
    {
        gameState.currentRoom = (GameManager.Room)37;
    }

}
