﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // every room has a north, south, west, and east exit potentially
    // maximum of 4 doors per room
    public class RoomDestinations
    {

        public int[] doors = new int[4];

    }

    static RoomDestinations currentDestinationList;

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

        currentDestinationList = new RoomDestinations();

        for (int i = 0; i < 4; i++)
        {
            //currentDestinationList.doors[i] = new Room();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static RoomDestinations returnDestinations(int id)
    {

        RoomDestinations dest = new RoomDestinations();

        switch (id)
        {
            case (int)Room.

        debug:
                dest.doors[0] = 1;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        frontDoor:
                dest.doors[0] = 2;
                dest.doors[1] = 8;
                dest.doors[2] = 14;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        foyer:
                dest.doors[0] = 3;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 1;
                break;

            case (int)Room.
        kitchen:
                dest.doors[0] = 5;
                dest.doors[1] = 0;
                dest.doors[2] = 4;
                dest.doors[3] = 2;
                break;

            case (int)Room.
        livingRoom:
                dest.doors[0] = 0;
                dest.doors[1] = 3;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        garden:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 3;
                break;

            case (int)Room.
        jewelryStore:
                dest.doors[0] = 0;
                dest.doors[1] = 7;
                dest.doors[2] = 0;
                dest.doors[3] = 15;
                break;

            case (int)Room.
        storeManagerRoom:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 6;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        lily:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 1;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        townHallEntrance:
                dest.doors[0] = 10;
                dest.doors[1] = 0;
                dest.doors[2] = 11;
                dest.doors[3] = 22;
                break;

            case (int)Room.
        townHallGym:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 9;
                break;

            case (int)Room.
        townHallSecondFloor:
                dest.doors[0] = 12;
                dest.doors[1] = 9;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        mayorsOffice:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 11;
                break;

            case (int)Room.
        oliverBackyard:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 14;
                break;

            case (int)Room.
        oliver:
                dest.doors[0] = 13;
                dest.doors[1] = 1;
                dest.doors[2] = 15;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        northMainStreet:
                dest.doors[0] = 6;
                dest.doors[1] = 14;
                dest.doors[2] = 0;
                dest.doors[3] = 16;
                break;

            case (int)Room.
        mainStreetPlazaGate:
                dest.doors[0] = 15;
                dest.doors[1] = 22;
                dest.doors[2] = 0;
                dest.doors[3] = 17;
                break;

            case (int)Room.
        southMainStreet:
                dest.doors[0] = 16;
                dest.doors[1] = 22;
                dest.doors[2] = 19;
                dest.doors[3] = 23;
                break;

            case (int)Room.
        roseParkNorthWest:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 20;
                dest.doors[3] = 19;
                break;

            case (int)Room.
        roseParkSouthWest:
                dest.doors[0] = 18;
                dest.doors[1] = 17;
                dest.doors[2] = 21;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        roseParkNorthEast:
                dest.doors[0] = 0;
                dest.doors[1] = 18;
                dest.doors[2] = 0;
                dest.doors[3] = 21;
                break;

            case (int)Room.
        roseParkSouthEast:
                dest.doors[0] = 20;
                dest.doors[1] = 19;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        townPlaza:
                dest.doors[0] = 9;
                dest.doors[1] = 0;
                dest.doors[2] = 17;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        towerEntrance:
                dest.doors[0] = 17;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 24;
                break;

            case (int)Room.
        towerReception:
                dest.doors[0] = 23;
                dest.doors[1] = 0;
                dest.doors[2] = 25;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        towerElevators:
                dest.doors[0] = 0;
                dest.doors[1] = 24;
                dest.doors[2] = 26;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        towerFirstFloor:
                dest.doors[0] = 0;
                dest.doors[1] = 25;
                dest.doors[2] = 27;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        towerSecondFloor:
                dest.doors[0] = 0;
                dest.doors[1] = 26;
                dest.doors[2] = 28;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        towerThirdFloor:
                dest.doors[0] = 29;
                dest.doors[1] = 27;
                dest.doors[2] = 30;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        towerCloset:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 28;
                break;

            case (int)Room.
        towerOffice:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        glassBridge:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        woodsEntrance:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        woods1:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        woods2:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        woods3:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        woods4:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        woods5:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        outsideShack:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        shack1:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        shack2:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        shack3:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        caveEntrance:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        cave1:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        cave2:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        caveFinalArea:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        detectiveLab:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            case (int)Room.
        detectiveOffice:
                dest.doors[0] = 0;
                dest.doors[1] = 0;
                dest.doors[2] = 0;
                dest.doors[3] = 0;
                break;

            default:

                return dest;

        }

        currentDestinationList = dest;
        return dest;

    }

    public void northButtonPressed()
    {
        currentRoom = (Room) currentDestinationList.doors[0];
        Debug.Log("Travel north to room " + currentDestinationList.doors[0]);
    }

    public void westButtonPressed()
    {
        currentRoom = (Room)currentDestinationList.doors[1];
        Debug.Log("Travel west to room " + currentDestinationList.doors[1]);

    }

    public void eastButtonPressed()
    {
        currentRoom = (Room)currentDestinationList.doors[2];
        Debug.Log("Travel east to room " + currentDestinationList.doors[2]);

    }

    public void southButtonPressed()
    {
        currentRoom = (Room)currentDestinationList.doors[3];
        Debug.Log("Travel south to room " + currentDestinationList.doors[3]);

    }

}
