using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour
{

    public GameManager gameState;
    public Image background;

    public Sprite[] roomBackgrounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // set current roomBG
        int currentRoomID = (int) gameState.currentRoom;
        background.sprite = roomBackgrounds[currentRoomID];

    }
}
