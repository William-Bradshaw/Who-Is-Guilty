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

    }
}
