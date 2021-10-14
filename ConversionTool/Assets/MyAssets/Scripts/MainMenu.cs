using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public bool mainMenu = true;
    public bool convertLength = false;
    public bool convertWeight = false;
    public bool convertTemp = false;
    public bool convertTime = false;
    public bool convertArea = false;
    public Dropdown mainMenuD;
    public GameObject mMenu;
    public GameObject cLength;
    public GameObject cWeight;
    public GameObject cTemp;
    public GameObject cTime;
    public GameObject cArea;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Escape)) {
            if (mainMenu) {
                quitApp ();
            } else {
                mainMenu = true;
                convertLength = false;
                convertWeight = false;
                convertTemp = false;
                convertTime = false;
                convertArea = false;
            }
        }
        if (convertLength) {
            cLength.SetActive (true);
            mMenu.SetActive (false);
            cWeight.SetActive (false);
            cTemp.SetActive (false);
            cTime.SetActive (false);
            cArea.SetActive (false);
        }
        if (convertWeight) {
            cLength.SetActive (false);
            mMenu.SetActive (false);
            cWeight.SetActive (true);
            cTemp.SetActive (false);
            cTime.SetActive (false);
            cArea.SetActive (false);
        }
        if (mainMenu) {
            cLength.SetActive (false);
            mMenu.SetActive (true);
            cWeight.SetActive (false);
            cTemp.SetActive (false);
            cTime.SetActive (false);
            cArea.SetActive (false);
        }
        if (convertTemp) {
            cLength.SetActive (false);
            mMenu.SetActive (false);
            cWeight.SetActive (false);
            cTemp.SetActive (true);
            cTime.SetActive (false);
            cArea.SetActive (false);
        }
        if (convertTime) {
            cLength.SetActive (false);
            mMenu.SetActive (false);
            cWeight.SetActive (false);
            cTemp.SetActive (false);
            cTime.SetActive (true);
            cArea.SetActive (false);
        }
        if (convertArea) {
            cLength.SetActive (false);
            mMenu.SetActive (false);
            cWeight.SetActive (false);
            cTemp.SetActive (false);
            cTime.SetActive (false);
            cArea.SetActive (true);
        }

    }

    public void quitApp () {
        Application.Quit ();
    }

    public void returnButton () {
        mainMenu = true;
        convertLength = false;
        convertWeight = false;
        convertTemp = false;
        convertTime = false;
        convertArea = false;
    }

    public void changeMenu () {
        switch (mainMenuD.value + 1) {
            case 1: //Length
                mainMenu = false;
                convertLength = true;
                convertWeight = false;
                convertTemp = false;
                convertTime = false;
                convertArea = false;
                return;
            case 2: //Weight
                mainMenu = false;
                convertLength = false;
                convertWeight = true;
                convertTemp = false;
                convertTime = false;
                convertArea = false;
                return;
            case 3: //Temp
                mainMenu = false;
                convertLength = false;
                convertWeight = false;
                convertTemp = true;
                convertTime = false;
                convertArea = false;
                return;
            case 4: //Time
                mainMenu = false;
                convertLength = false;
                convertWeight = false;
                convertTemp = false;
                convertTime = true;
                convertArea = false;
                return;
            case 6:
                mainMenu = false;
                convertLength = false;
                convertWeight = false;
                convertTemp = false;
                convertTime = false;
                convertArea = true;
                return;
        }

    }
}