using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Lean.Gui;


public class Clue : MonoBehaviour
{

    public int id;
    public bool menuScreenVersion;

    private GameObject GameManagerObject;
    private GameManager GlobalGameManager;

    private Image clueImage;

    private LeanButton clueButton;

    // Start is called before the first frame update
    void Start()
    {
        clueImage = GetComponentInChildren<Image>();

        GameManagerObject = GameObject.Find("GameManager");
        GlobalGameManager = GameManagerObject.GetComponent<GameManager>();

        clueButton = gameObject.GetComponent<LeanButton>();

    }

    // Update is called once per frame
    void Update()
    {

        if (clueButton.IsInvoking())
        {
            if (!menuScreenVersion)
            {
                collectClue();
            }
        }


        if (menuScreenVersion)
        {

            // show clue on menu if found
            // if not, show clue in black
            if (GlobalGameManager.clueFlags[id])
            {
                clueImage.color = new Color(255, 255, 255, 255);
            }
            else
            {
                clueImage.color = new Color(0, 0, 0, 100);
            }

        }


    }

    public void collectClue()
    {

        // set clue as found
        GlobalGameManager.clueFlags[id] = true;

        // remove clue from screen
        Destroy(gameObject);

    }
}
