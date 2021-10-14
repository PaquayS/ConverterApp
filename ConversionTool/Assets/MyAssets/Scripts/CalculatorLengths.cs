using System.Collections;
using System.Collections.Generic;
using System.Globalization;

using UnityEngine;
using UnityEngine.UI;

public class CalculatorLengths : MonoBehaviour {
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
                    kiloMeter ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 2:
                    meter ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 3:
                    centiMeter ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 4:
                    miliMeter ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 5:
                    miles ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 6:
                    yard ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 7:
                    foot ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 8:
                    inch ();
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

    void kiloMeter () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer
                result = givenValue;
                break;

            case 2: //Meter
                result = givenValue * Mathf.Pow (10, 3);
                break;

            case 3: //Centimeter
                result = givenValue * Mathf.Pow (10, 5);
                break;

            case 4: //Milimeter
                result = givenValue * Mathf.Pow (10, 6);
                break;

            case 5: //Miles
                result = givenValue * 0.62137f;
                break;

            case 6: //Yard
                result = givenValue * 1093.613298f;
                break;

            case 7: //Foot
                result = givenValue * 3280.84f;
                break;

            case 8: //Inch
                result = givenValue * 39370.1f;
                break;
        }

        resultString = result.ToString ();
    }

    void meter () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer
                result = givenValue * Mathf.Pow (10, -3);
                break;

            case 2: //Meter
                result = givenValue;
                break;

            case 3: //Centimeter
                result = givenValue * Mathf.Pow (10, 2);
                break;

            case 4: //Milimeter
                result = givenValue * Mathf.Pow (10, 3);
                break;

            case 5: //Miles
                result = givenValue / 1609.344f;
                break;

            case 6: //Yard
                result = givenValue * 1.093613298f;
                break;

            case 7: //Foot
                result = givenValue * 3.280839895f;
                break;

            case 8: //Inch
                result = givenValue * 39.37007874f;
                break;
        }
        resultString = result.ToString ();
    }

    void centiMeter () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer
                result = givenValue * Mathf.Pow (10, -5);
                break;

            case 2: //Meter
                result = givenValue * Mathf.Pow (10, -2);
                break;

            case 3: //Centimeter
                result = givenValue;
                break;

            case 4: //Milimeter
                result = givenValue * Mathf.Pow (10, 1);
                break;

            case 5: //Miles
                result = givenValue / 160934.4f;
                break;

            case 6: //Yard
                result = givenValue * 0.01093613298f;
                break;

            case 7: //Foot
                result = givenValue / 30.48f;
                break;

            case 8: //Inch
                result = givenValue * 0.3937007874f;
                break;
        }
        resultString = result.ToString ();
    }

    void miliMeter () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer
                result = givenValue * Mathf.Pow (10, -6);
                break;

            case 2: //Meter
                result = givenValue * Mathf.Pow (10, -3);
                break;

            case 3: //Centimeter
                result = givenValue * Mathf.Pow (10, -1);
                break;

            case 4: //Milimeter
                result = givenValue;
                break;

            case 5: //Miles
                result = givenValue * (6.21371192f * Mathf.Pow (10, -7));
                break;

            case 6: //Yard
                result = givenValue / (91.44f * Mathf.Pow (10, 1));
                break;

            case 7: //Foot
                result = givenValue / 304.799990246f;
                break;

            case 8: //Inch
                result = givenValue / 25.4f;
                break;
        }
        resultString = result.ToString ();
    }

    void miles () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer
                result = givenValue * 1.609344f;
                break;

            case 2: //Meter
                result = givenValue * 1609.344f;
                break;

            case 3: //Centimeter
                result = givenValue * 160934.4f;
                break;

            case 4: //Milimeter
                result = givenValue * 1609344.0f;
                break;

            case 5: //Miles
                result = givenValue;
                break;

            case 6: //Yard
                result = givenValue * 1760f;
                break;

            case 7: //Foot
                result = givenValue * 5280f;
                break;

            case 8: //Inch
                result = givenValue * 63360f;
                break;
        }
        resultString = result.ToString ();
    }

    void yard () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer
                result = givenValue * 0.0009144f;
                break;

            case 2: //Meter
                result = givenValue * 0.9144f;
                break;

            case 3: //Centimeter
                result = givenValue * 91.44f;
                break;

            case 4: //Milimeter
                result = givenValue * 914.4f;
                break;

            case 5: //Miles
                result = givenValue / 1760f;
                break;

            case 6: //Yard
                result = givenValue;
                break;

            case 7: //Foot
                result = givenValue * 3f;
                break;

            case 8: //Inch
                result = givenValue * 36f;
                break;
        }
        resultString = result.ToString ();
    }

    void foot () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer
                result = givenValue / 3280.84f;
                break;

            case 2: //Meter
                result = givenValue * 0.3048f;
                break;

            case 3: //Centimeter
                result = givenValue * 30.48f;
                break;

            case 4: //Milimeter
                result = givenValue * 304.8f;
                break;

            case 5: //Miles
                result = givenValue / 5280f;
                break;

            case 6: //Yard
                result = givenValue / 3f;
                break;

            case 7: //Foot
                result = givenValue;
                break;

            case 8: //Inch
                result = givenValue * 12f;
                break;
        }
        resultString = result.ToString ();
    }

    void inch () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer
                result = givenValue / 39370.1f;
                break;

            case 2: //Meter
                result = givenValue * 0.0254f;
                break;

            case 3: //Centimeter
                result = givenValue * 2.54f;
                break;

            case 4: //Milimeter
                result = givenValue * 25.4f;
                break;

            case 5: //Miles
                result = givenValue / 63360f;
                break;

            case 6: //Yard
                result = givenValue / 36f;
                break;

            case 7: //Foot
                result = givenValue / 12f;
                break;

            case 8: //Inch
                result = givenValue;
                break;
        }
        resultString = result.ToString ();
    }
}