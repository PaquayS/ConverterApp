using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class calculatorTemp : MonoBehaviour {
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
                    celcius ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 2:
                    fahrenheit ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 3:
                    kelvin ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 4:
                    rankine ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 5:
                    delisle ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 6:
                    newton ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 7:
                    reaumur ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 8:
                    romer ();
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

    void celcius () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //celsius
                result = givenValue;
                break;
            case 2: //fahrenheit
                result = givenValue * 1.8f + 32f;
                break;
            case 3: //kelvin
                result = givenValue + 273.15f;
                break;
            case 4: //rankine
                result = (givenValue + 273.15f) * 1.8f;
                break;
            case 5: //delisle
                result = (100f - givenValue) * 1.5f;
                break;
            case 6: //newton
                result = givenValue * 0.33f;
                break;
            case 7: //reaumur
                result = givenValue * 0.8f;
                break;
            case 8: //romer
                result = givenValue * 0.525f + 7.5f;
                break;
        }
        resultString = result.ToString ();

    }
    void fahrenheit () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //celsius
                result = (givenValue - 32f) * (5f / 9f);
                break;
            case 2: //fahrenheit
                result = givenValue;
                break;
            case 3: //kelvin
                result = (givenValue + 459.67f) * (5f / 9f);
                break;
            case 4: //rankine
                result = (givenValue + 459.67f);
                break;
            case 5: //delisle
                result = (212f - givenValue) * (5f / 6f);
                break;
            case 6: //newton
                result = (givenValue - 32f) * (11f / 60f);
                break;
            case 7: //reaumur
                result = (givenValue - 32f) * (4f / 9f);
                break;
            case 8: //romer
                result = (givenValue - 32f) * (7f / 24f) + 7.5f;
                break;
        }
        resultString = result.ToString ();

    }
    void kelvin () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //celsius
                result = givenValue - 273.15f;
                break;
            case 2: //fahrenheit
                result = givenValue * 1.8f - 459.67f;
                break;
            case 3: //kelvin
                result = givenValue;
                break;
            case 4: //rankine
                result = givenValue * 1.8f;
                break;
            case 5: //delisle
                result = (373.15f - givenValue) * 1.5f;
                break;
            case 6: //newton
                result = (givenValue - 237.15f) * 0.33f;
                break;
            case 7: //reaumur
                result = (givenValue - 237.15f) * 0.8f;
                break;
            case 8: //romer
                result = (givenValue - 237.15f) * (21f / 40f) + 7.5f;
                break;
        }
        resultString = result.ToString ();

    }
    void rankine () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //celsius
                result = (givenValue - 491.67f) * (5f / 9f);
                break;
            case 2: //fahrenheit
                result = givenValue - 459.67f;
                break;
            case 3: //kelvin
                result = (givenValue) * (5f / 9f);
                break;
            case 4: //rankine
                result = (givenValue);
                break;
            case 5: //delisle
                result = (671.67f - givenValue) * (5f / 6f);
                break;
            case 6: //newton
                result = (givenValue - 491.67f) * (11f / 60f);
                break;
            case 7: //reaumur
                result = (givenValue - 491.67f) * (4f / 9f);
                break;
            case 8: //romer
                result = (givenValue - 491.67f) * (7f / 24f) + 7.5f;
                break;
        }
        resultString = result.ToString ();

    }
    void delisle () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //celsius
                result = 100f - givenValue * (2f / 3f);
                break;
            case 2: //fahrenheit
                result = 212 - givenValue * 1.2f;
                break;
            case 3: //kelvin
                result = 373.15f - (givenValue) * (2f / 3f);
                break;
            case 4: //rankine
                result = 671.67f - (givenValue) * 1.2f;
                break;
            case 5: //delisle
                result = (givenValue);
                break;
            case 6: //newton
                result = 33f - (givenValue) * (11f / 50f);
                break;
            case 7: //reaumur
                result = 80f - (givenValue) * (8f / 15f);
                break;
            case 8: //romer
                result = 60f - (givenValue) * (7f / 20f);
                break;
        }
        resultString = result.ToString ();

    }
    void newton () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //celsius
                result = givenValue * (100f / 33f);
                break;
            case 2: //fahrenheit
                result = givenValue * (60f / 11f) + 32f;
                break;
            case 3: //kelvin
                result = givenValue * (100f / 33f) + 273.15f;
                break;
            case 4: //rankine
                result = givenValue * (60f / 11f) + 491.67f;
                break;
            case 5: //delisle
                result = (33f - givenValue) * (50f / 11f);
                break;
            case 6: //newton
                result = (givenValue);
                break;
            case 7: //reaumur
                result = (givenValue) * (80f / 33f);
                break;
            case 8: //romer
                result = (givenValue) * (35f / 22f) + 7.5f;
                break;
        }
        resultString = result.ToString ();

    }
    void reaumur () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //celsius
                result = givenValue * (1.25f);
                break;
            case 2: //fahrenheit
                result = givenValue * (9f / 4f) + 32f;
                break;
            case 3: //kelvin
                result = givenValue * (5f / 4f) + 273.15f;
                break;
            case 4: //rankine
                result = givenValue * (9f / 4f) + 491.67f;
                break;
            case 5: //delisle
                result = (80f - givenValue) * (15f / 8f);
                break;
            case 6: //newton
                result = (givenValue) * (33f / 80f);
                break;
            case 7: //reaumur
                result = (givenValue);
                break;
            case 8: //romer
                result = (givenValue) * (21f / 32f) + 7.5f;
                break;
        }
        resultString = result.ToString ();

    }
    void romer () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //celsius
                result = (givenValue - 7.5f) * (40f / 21f);
                break;
            case 2: //fahrenheit
                result = (givenValue - 7.5f) * (24f / 7f) + 32f;
                break;
            case 3: //kelvin
                result = (givenValue - 7.5f) * (40f / 21f) + 273.15f;
                break;
            case 4: //rankine
                result = (givenValue - 7.5f) * (24f / 7f) + 491.67f;
                break;
            case 5: //delisle
                result = (60f - givenValue) * (20f / 7f);
                break;
            case 6: //newton
                result = (givenValue - 7.5f) * (22f /35f);
                break;
            case 7: //reaumur
                result = (givenValue - 7.5f) * (32f / 21f);
                break;
            case 8: //romer
                result = (givenValue);
                break;
        }
        resultString = result.ToString ();

    }
}