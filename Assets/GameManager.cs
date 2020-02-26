using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public enum Room
    {
        debug,
        frontDoor,
        foyer,
        kitchen,
        livingRoom,
        garden,
        jewelryStore,
        storeManagerRoom,
        lily,
        townHallEntrance,
        townHallGym,
        townHallSecondFloor,
        mayorsOffice,
        oliverBackyard,
        oliver,
        northMainStreet,
        mainStreetPlazaGate,
        southMainStreet,
        roseParkNorthWest,
        roseParkSouthWest,
        roseParkNorthEast,
        roseParkSouthEast,
        townPlaza,
        towerEntrance,
        towerReception,
        towerElevators,
        towerFirstFloor,
        towerSecondFloor,
        towerThirdFloor,
        towerCloset,
        towerOffice,
        glassBridge,
        woodsEntrance,
        woods1,
        woods2,
        woods3,
        woods4,
        woods5,
        outsideShack,
        shack1,
        shack2,
        shack3,
        caveEntrance,
        cave1,
        cave2,
        caveFinalArea,
        detectiveLab,
        detectiveOffice
    };

    public string playerName = "PLAYER";
    public Room currentRoom = Room.frontDoor;

    public bool[] eventFlags;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
