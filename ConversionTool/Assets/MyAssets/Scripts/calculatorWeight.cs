using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class calculatorWeight : MonoBehaviour {
    public Dropdown unitGiven;
    public Dropdown unitWanted;
    public InputField valueGiven;
    public Text valueWanted;
    float givenValue = 0f;
    float result;
    string resultString;
    bool convertValue = false;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        // givenValue = valueGiven;
        int unitGivenValue = unitGiven.value + 1;

        if (convertValue) {
            switch (unitGivenValue) {
                case 1:
                    tonMetric ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 2:
                    kilogram ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 3:
                    gram ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 4:
                    americanTon ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 5:
                    americanCWT ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 6:
                    britishTon ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 7:
                    britishCWT ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 8:
                    stone ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;
                case 9:
                    pound ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;
                case 10:
                    ounce ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;
            }
        }
    }

    // public void changeValue(){
    //     Debug.Log(unitGiven.options[unitGiven.value].text);
    // }

    public void convertValues () {
        convertValue = true;
        givenValue = float.Parse (valueGiven.text);
    }

    void tonMetric () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = givenValue;
                break;

            case 2: //kilogram
                result = givenValue * Mathf.Pow (10, 3);
                break;

            case 3: //gram
                result = givenValue * Mathf.Pow (10, 6);
                break;

            case 4: //American/short Ton
                result = givenValue * 1.10231131f;
                break;

            case 5: //American CWT
                result = givenValue * 22.046226218488f;
                break;

            case 6: //UK/long Ton
                result = givenValue * 0.984207f;
                break;

            case 7: //UK/long CWT
                result = givenValue * 19.684130552221f;
                break;

            case 8: //Stone
                result = givenValue * 157.473044f;
                break;

            case 9: //Pound
                result = givenValue * 2204.62262f;
                break;

            case 10: //Ounce
                result = givenValue * 35273.96f;
                break;
        }
        resultString = result.ToString ();
    }

    void kilogram () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = givenValue * Mathf.Pow (10, -3);
                break;

            case 2: //kilogram
                result = givenValue;
                break;

            case 3: //gram
                result = givenValue * Mathf.Pow (10, 3);
                break;

            case 4: //American/short Ton
                result = (givenValue * 1.10231131f) * Mathf.Pow (10, -3);
                break;

            case 5: //American CWT
                result = (givenValue * 22.046226218488f) * Mathf.Pow (10, -3);
                break;

            case 6: //UK/long Ton
                result = (givenValue * 0.984207f) * Mathf.Pow (10, -3);
                break;

            case 7: //UK/long CWT
                result = (givenValue * 19.684130552221f) * Mathf.Pow (10, -3);
                break;

            case 8: //Stone
                result = (givenValue * 157.473044f) * Mathf.Pow (10, -3);
                break;

            case 9: //Pound
                result = (givenValue * 2204.62262f) * Mathf.Pow (10, -3);
                break;

            case 10: //Ounce
                result = (givenValue * 35273.96f) * Mathf.Pow (10, -3);
                break;
        }
        resultString = result.ToString ();
    }

    void gram () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = givenValue * Mathf.Pow (10, -6);
                break;

            case 2: //kilogram
                result = givenValue * Mathf.Pow (10, -3);
                break;

            case 3: //gram
                result = givenValue;
                break;

            case 4: //American/short Ton
                result = (givenValue * 1.10231131f) * Mathf.Pow (10, -6);
                break;

            case 5: //American CWT
                result = (givenValue * 22.046226218488f) * Mathf.Pow (10, -6);
                break;

            case 6: //UK/long Ton
                result = (givenValue * 0.984207f) * Mathf.Pow (10, -6);
                break;

            case 7: //UK/long CWT
                result = (givenValue * 19.684130552221f) * Mathf.Pow (10, -6);
                break;

            case 8: //Stone
                result = (givenValue * 157.473044f) * Mathf.Pow (10, -6);
                break;

            case 9: //Pound
                result = (givenValue * 2204.62262f) * Mathf.Pow (10, -6);
                break;

            case 10: //Ounce
                result = (givenValue * 35273.96f) * Mathf.Pow (10, -6);
                break;
        }
        resultString = result.ToString ();
    }

    void americanTon () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = givenValue * 0.90718474f;
                break;

            case 2: //kilogram
                result = (givenValue * 0.90718474f) * Mathf.Pow (10, 3);
                break;

            case 3: //gram
                result = (givenValue * 0.90718474f) * Mathf.Pow (10, 6);
                break;

            case 4: //American/short Ton
                result = givenValue;
                break;

            case 5: //American CWT
                result = givenValue * 20f;
                break;

            case 6: //UK/long Ton
                result = givenValue * 0.892857143f;
                break;

            case 7: //UK/long CWT
                result = givenValue * 17.857142857142858f;
                break;

            case 8: //Stone
                result = givenValue * 142.857143f;
                break;

            case 9: //Pound
                result = givenValue * 2000f;
                break;

            case 10: //Ounce
                result = givenValue * 32000f;
                break;
        }
        resultString = result.ToString ();
    }

    void americanCWT () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = (givenValue * 0.90718474f) / 20f;
                break;

            case 2: //kilogram
                result = ((givenValue * 0.90718474f) * Mathf.Pow (10, 3)) / 20f;
                break;

            case 3: //gram
                result = ((givenValue * 0.90718474f) * Mathf.Pow (10, 6)) / 20f;
                break;

            case 4: //American/short Ton
                result = givenValue * 0.05f;
                break;

            case 5: //American CWT
                result = givenValue;
                break;

            case 6: //UK/long Ton
                result = (givenValue * 0.044643f) / 20f;
                break;

            case 7: //UK/long CWT
                result = (givenValue * 17.857142857142858f) / 20f;
                break;

            case 8: //Stone
                result = (givenValue * 142.857143f) / 20f;
                break;

            case 9: //Pound
                result = givenValue * 100f;
                break;

            case 10: //Ounce
                result = givenValue * 1600f;
                break;
        }
        resultString = result.ToString ();
    }

    void britishTon () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = (givenValue * 1.01604691f);
                break;

            case 2: //kilogram
                result = ((givenValue * 1.01604691f) * Mathf.Pow (10, 3));
                break;

            case 3: //gram
                result = ((givenValue * 1.01604691f) * Mathf.Pow (10, 6));
                break;

            case 4: //American/short Ton
                result = givenValue * 1.12f;
                break;

            case 5: //American CWT
                result = givenValue * 22.4f;
                break;

            case 6: //UK/long Ton
                result = givenValue;
                break;

            case 7: //UK/long CWT
                result = givenValue * 20f;
                break;

            case 8: //Stone
                result = givenValue * 160f;
                break;

            case 9: //Pound
                result = givenValue * 2240f;
                break;

            case 10: //Ounce
                result = givenValue * 35840f;
                break;
        }
        resultString = result.ToString ();

    }

    void britishCWT () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = ((givenValue * 1.01604691f)) / 20f;
                break;

            case 2: //kilogram
                result = ((givenValue * 1.01604691f) * Mathf.Pow (10, 3)) / 20f;
                break;

            case 3: //gram
                result = ((givenValue * 1.01604691f) * Mathf.Pow (10, 6)) / 20f;
                break;

            case 4: //American/short Ton
                result = (givenValue * 1.12f) / 20f;
                break;

            case 5: //American CWT
                result = (givenValue * 22.4f) / 20f;
                break;

            case 6: //UK/long Ton
                result = givenValue / 20f;
                break;

            case 7: //UK/long CWT
                result = givenValue;
                break;

            case 8: //Stone
                result = givenValue * 8f;
                break;

            case 9: //Pound
                result = givenValue * 120f;
                break;

            case 10: //Ounce
                result = givenValue * 1792f;
                break;
        }
        resultString = result.ToString ();

    }

    void stone () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = ((givenValue * 0.00635029318f));
                break;

            case 2: //kilogram
                result = ((givenValue * 0.00635029318f) * Mathf.Pow (10, 3));
                break;

            case 3: //gram
                result = ((givenValue * 0.00635029318f) * Mathf.Pow (10, 6));
                break;

            case 4: //American/short Ton
                result = givenValue * 0.007f;
                break;

            case 5: //American CWT
                result = givenValue * 0.14f;
                break;

            case 6: //UK/long Ton
                result = givenValue * 0.00625f;
                break;

            case 7: //UK/long CWT
                result = givenValue * 0.12f;
                break;

            case 8: //Stone
                result = givenValue;
                break;

            case 9: //Pound
                result = givenValue * 14f;
                break;

            case 10: //Ounce
                result = givenValue * 224f;
                break;
        }
        resultString = result.ToString ();

    }

    void pound () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = ((givenValue * 0.00635029318f)) / 14f;
                break;

            case 2: //kilogram
                result = ((givenValue * 0.00635029318f) * Mathf.Pow (10, 3)) / 14f;
                break;

            case 3: //gram
                result = ((givenValue * 0.00635029318f) * Mathf.Pow (10, 6)) / 14f;
                break;

            case 4: //American/short Ton
                result = (givenValue * 0.007f) / 14f;
                break;

            case 5: //American CWT
                result = (givenValue * 0.14f) / 14f;
                break;

            case 6: //UK/long Ton
                result = (givenValue * 0.00625f) / 14f;
                break;

            case 7: //UK/long CWT
                result = (givenValue * 0.12f) / 14f;
                break;

            case 8: //Stone
                result = givenValue / 14f;
                break;

            case 9: //Pound
                result = givenValue;
                break;

            case 10: //Ounce
                result = givenValue * 16f;
                break;
        }
        resultString = result.ToString ();

    }

    void ounce () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //metric Ton
                result = ((givenValue * 0.00635029318f)) / 224f;
                break;

            case 2: //kilogram
                result = ((givenValue * 0.00635029318f) * Mathf.Pow (10, 3)) / 224f;
                break;

            case 3: //gram
                result = ((givenValue * 0.00635029318f) * Mathf.Pow (10, 6)) / 224f;
                break;

            case 4: //American/short Ton
                result = (givenValue * 0.007f) / 224f;
                break;

            case 5: //American CWT
                result = (givenValue * 0.14f) / 224f;
                break;

            case 6: //UK/long Ton
                result = (givenValue * 0.00625f) / 224f;
                break;

            case 7: //UK/long CWT
                result = (givenValue * 0.12f) / 224f;
                break;

            case 8: //Stone
                result = givenValue / 224f;
                break;

            case 9: //Pound
                result = givenValue / 16f;
                break;

            case 10: //Ounce
                result = givenValue;
                break;
        }
        resultString = result.ToString ();

    }
}