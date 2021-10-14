using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class calculatorArea : MonoBehaviour {
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
                    kiloMeter2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 2:
                    meter2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 3:
                    centiMeter2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 4:
                    miliMeter2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 5:
                    hectare ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 6:
                    miles2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 7:
                    acre ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 8:
                    yard2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 9:
                    foot2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 10:
                    inch2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 11:
                    nMiles2 ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 12:
                    dunam ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 13:
                    tsubo ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 14:
                    pyeong ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 15:
                    cuerda ();
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

    void kiloMeter2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue;
                break;

            case 2: //Meter2
                result = givenValue * Mathf.Pow (10, 6);
                break;

            case 3: //Centimeter2
                result = givenValue * Mathf.Pow (10, 10);
                break;

            case 4: //Milimeter2
                result = givenValue * Mathf.Pow (10, 12);
                break;

            case 5: //hectare
                result = givenValue * 100f;
                break;
            case 6: //Miles2
                result = givenValue * 0.386102f;
                break;

            case 7: //acre
                result = givenValue * 247.105381f;
                break;

            case 8: //yard2
                result = givenValue * 1195990.05f;
                break;

            case 9: //feet2
                result = givenValue * 10763910.4f;
                break;
            case 10: //Inch2
                result = givenValue * (1.5500031f * Mathf.Pow (10, 9));
                break;

            case 11: //square nautical mile
                result = givenValue * 0.2915533496f;
                break;
            case 12: //dunam (middle east)
                result = givenValue * 1000f;
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 302500f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 302500f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * 254.4529262f;
                break;
        }

        resultString = result.ToString ();
    }

    void meter2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * Mathf.Pow (10, -6);
                break;

            case 2: //Meter2
                result = givenValue;
                break;

            case 3: //Centimeter2
                result = givenValue * Mathf.Pow (10, 4);
                break;

            case 4: //Milimeter2
                result = givenValue * Mathf.Pow (10, 6);
                break;

            case 5: //hectare
                result = givenValue * Mathf.Pow (10, -4);
                break;
            case 6: //Miles2
                result = givenValue * (3.861f * Mathf.Pow (10, -7));
                break;

            case 7: //acre
                result = givenValue * (247.105381f * Mathf.Pow (10, -6));
                break;

            case 8: //yard2
                result = givenValue * (1195990.05f * Mathf.Pow (10, -6));
                break;

            case 9: //feet2
                result = givenValue * (10763910.4f * Mathf.Pow (10, -6));
                break;
            case 10: //Inch2
                result = givenValue * (1.5500031f * Mathf.Pow (10, 3));
                break;

            case 11: //square nautical mile
                result = givenValue * (0.2915533496f * Mathf.Pow (10, -6));
                break;
            case 12: //dunam (middle east)
                result = givenValue * (1f * Mathf.Pow (10, -3));
                break;

            case 13: //tsubo (japanese)
                result = givenValue * (3025f * Mathf.Pow (10, -4));
                break;

            case 14: //pyeong (korean)
                result = givenValue * (3025f * Mathf.Pow (10, -4));
                break;

            case 15: //cuerda (spanish)
                result = givenValue * (254.4529262f * Mathf.Pow (10, -6));
                break;
        }

        resultString = result.ToString ();
    }

    void centiMeter2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * Mathf.Pow (10, -10);
                break;

            case 2: //Meter2
                result = givenValue * Mathf.Pow (10, -4);
                break;

            case 3: //Centimeter2
                result = givenValue;
                break;

            case 4: //Milimeter2
                result = givenValue * Mathf.Pow (10, 2);
                break;

            case 5: //hectare
                result = givenValue * (100f * Mathf.Pow (10, -10));
                break;
            case 6: //Miles2
                result = givenValue * (0.386102f * Mathf.Pow (10, -10));
                break;

            case 7: //acre
                result = givenValue * (247.105381f * Mathf.Pow (10, -10));
                break;

            case 8: //yard2
                result = givenValue * (1195990.05f * Mathf.Pow (10, -10));
                break;

            case 9: //feet2
                result = givenValue * (10763910.4f * Mathf.Pow (10, -10));
                break;
            case 10: //Inch2
                result = givenValue * (1.5500031f * Mathf.Pow (10, -1));
                break;

            case 11: //square nautical mile
                result = givenValue * (0.2915533496f * Mathf.Pow (10, -10));
                break;
            case 12: //dunam (middle east)
                result = givenValue * (1000f * Mathf.Pow (10, -10));
                break;

            case 13: //tsubo (japanese)
                result = givenValue * (302500f * Mathf.Pow (10, -10));
                break;

            case 14: //pyeong (korean)
                result = givenValue * (302500f * Mathf.Pow (10, -10));
                break;

            case 15: //cuerda (spanish)
                result = givenValue * (254.4529262f * Mathf.Pow (10, -10));
                break;
        }

        resultString = result.ToString ();
    }

    void miliMeter2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * Mathf.Pow (10, -12);
                break;

            case 2: //Meter2
                result = givenValue * Mathf.Pow (10, -6);
                break;

            case 3: //Centimeter2
                result = givenValue * Mathf.Pow (10, -2);
                break;

            case 4: //Milimeter2
                result = givenValue;
                break;

            case 5: //hectare
                result = givenValue * (100f * Mathf.Pow (10, -12));
                break;
            case 6: //Miles2
                result = givenValue * (0.386102f * Mathf.Pow (10, -12));
                break;

            case 7: //acre
                result = givenValue * (247.105381f * Mathf.Pow (10, -12));
                break;

            case 8: //yard2
                result = givenValue * (1195990.05f * Mathf.Pow (10, -12));
                break;

            case 9: //feet2
                result = givenValue * (10763910.4f * Mathf.Pow (10, -12));
                break;
            case 10: //Inch2
                result = givenValue * (1.5500031f * Mathf.Pow (10, -3));
                break;

            case 11: //square nautical mile
                result = givenValue * (0.2915533496f * Mathf.Pow (10, -12));
                break;
            case 12: //dunam (middle east)
                result = givenValue * (1000f * Mathf.Pow (10, -12));
                break;

            case 13: //tsubo (japanese)
                result = givenValue * (302500f * Mathf.Pow (10, -12));
                break;

            case 14: //pyeong (korean)
                result = givenValue * (302500f * Mathf.Pow (10, -12));
                break;

            case 15: //cuerda (spanish)
                result = givenValue * (254.4529262f * Mathf.Pow (10, -12));
                break;
        }

        resultString = result.ToString ();
    }

    void hectare () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * Mathf.Pow (10, -2);
                break;

            case 2: //Meter2
                result = givenValue * Mathf.Pow (10, 4);
                break;

            case 3: //Centimeter2
                result = givenValue * Mathf.Pow (10, 8);
                break;

            case 4: //Milimeter2
                result = givenValue * Mathf.Pow (10, 10);
                break;

            case 5: //hectare
                result = givenValue;
                break;
            case 6: //Miles2
                result = givenValue * 0.00386102f;
                break;

            case 7: //acre
                result = givenValue * 2.47105381f;
                break;

            case 8: //yard2
                result = givenValue * 11959.9005f;
                break;

            case 9: //feet2
                result = givenValue * 107639.104f;
                break;
            case 10: //Inch2
                result = givenValue * (1.5500031f * Mathf.Pow (10, 7));
                break;

            case 11: //square nautical mile
                result = givenValue * 0.002915533496f;
                break;
            case 12: //dunam (middle east)
                result = givenValue * 10f;
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 3025f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 3025f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * 2.544529262f;
                break;
        }

        resultString = result.ToString ();
    }

    void miles2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * 2.58998811f;
                break;

            case 2: //Meter2
                result = givenValue * (2.58998811f * Mathf.Pow (10, 6));
                break;

            case 3: //Centimeter2
                result = givenValue * (2.58998811f * Mathf.Pow (10, 10));
                break;

            case 4: //Milimeter2
                result = givenValue * (2.58998811f * Mathf.Pow (10, 12));
                break;

            case 5: //hectare
                result = givenValue * 258.998811f;
                break;
            case 6: //Miles2
                result = givenValue;
                break;

            case 7: //acre
                result = givenValue * 640f;
                break;

            case 8: //yard2
                result = givenValue * 3097600f;
                break;

            case 9: //feet2
                result = givenValue * 27878411.999612f;
                break;
            case 10: //Inch2
                result = givenValue * 4014489600f;
                break;

            case 11: //square nautical mile
                result = givenValue * 0.755119709f;
                break;
            case 12: //dunam (middle east)
                result = givenValue * 2589.988110336f;
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 783471.4033766f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 783471.4033766f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * 659.0300535f;
                break;
        }

        resultString = result.ToString ();
    }

    void acre () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * 0.00404685642f;
                break;

            case 2: //Meter2
                result = givenValue * (0.00404685642f * Mathf.Pow (10, 6));
                break;

            case 3: //Centimeter2
                result = givenValue * (0.00404685642f * Mathf.Pow (10, 10));
                break;

            case 4: //Milimeter2
                result = givenValue * (0.00404685642f * Mathf.Pow (10, 12));
                break;

            case 5: //hectare
                result = givenValue * 000.404685642f;
                break;
            case 6: //Miles2
                result = givenValue / 640f;
                break;

            case 7: //acre
                result = givenValue;
                break;

            case 8: //yard2
                result = givenValue * 4840f;
                break;

            case 9: //feet2
                result = givenValue * 43560f;
                break;
            case 10: //Inch2
                result = givenValue * 6272640f;
                break;

            case 11: //square nautical mile
                result = givenValue * 0.001179874545f;
                break;
            case 12: //dunam (middle east)
                result = givenValue * 4.04685642f;
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 1224.17f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 1224.17f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * 1.0296308078f;
                break;
        }

        resultString = result.ToString ();
    }

    void yard2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * (8.3612736f * Mathf.Pow (10, -7));
                break;

            case 2: //Meter2
                result = givenValue * (8.3612736f * Mathf.Pow (10, -1));
                break;

            case 3: //Centimeter2
                result = givenValue * (8.3612736f * Mathf.Pow (10, 3));
                break;

            case 4: //Milimeter2
                result = givenValue * (8.3612736f * Mathf.Pow (10, 5));
                break;

            case 5: //hectare
                result = givenValue * (8.3612736f * Mathf.Pow (10, -5));
                break;
            case 6: //Miles2
                result = givenValue / 3097600f;
                break;

            case 7: //acre
                result = givenValue / 4840f;
                break;

            case 8: //yard2
                result = givenValue;
                break;

            case 9: //feet2
                result = givenValue * 9f;
                break;
            case 10: //Inch2
                result = givenValue * 1296f;
                break;

            case 11: //square nautical mile
                result = givenValue * (2.43448318579880134076315817522916799185955564746048168634542558840330623f * Mathf.Pow (10, -7));
                break;
            case 12: //dunam (middle east)
                result = givenValue * 0.00083612736f;
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 0.25292738822675f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 0.25292738822675f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * 0.00021273363797824f;
                break;
        }

        resultString = result.ToString ();
    }

    void foot2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * (9.290304f * Mathf.Pow (10, -8));
                break;

            case 2: //Meter2
                result = givenValue * (9.290304f * Mathf.Pow (10, -2));
                break;

            case 3: //Centimeter2
                result = givenValue * (9.290304f * Mathf.Pow (10, 2));
                break;

            case 4: //Milimeter2
                result = givenValue * (9.290304f * Mathf.Pow (10, 4));
                break;

            case 5: //hectare
                result = givenValue * (9.290304f * Mathf.Pow (10, -6));
                break;
            case 6: //Miles2
                result = givenValue / 27878400f;
                break;

            case 7: //acre
                result = givenValue * (2.29568411f * Mathf.Pow (10, -5));
                break;

            case 8: //yard2
                result = givenValue / 9f;
                break;

            case 9: //feet2
                result = givenValue;
                break;
            case 10: //Inch2
                result = givenValue * 144f;
                break;

            case 11: //square nautical mile
                result = givenValue * (2.708616860586f * Mathf.Pow (10, -8));
                break;
            case 12: //dunam (middle east)
                result = givenValue * (9.290304f * Mathf.Pow (10, -5));
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 0.0281031696f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 0.0281031696f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * (2.36f * Mathf.Pow (10, -5));
                break;
        }

        resultString = result.ToString ();
    }

    void inch2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * (6.4516f * Mathf.Pow (10, -10));
                break;

            case 2: //Meter2
                result = givenValue * (6.4516f * Mathf.Pow (10, -4));
                break;

            case 3: //Centimeter2
                result = givenValue * (6.4516f);
                break;

            case 4: //Milimeter2
                result = givenValue * 645.16f;
                break;

            case 5: //hectare
                result = givenValue * (6.4516f * Mathf.Pow (10, -8));
                break;
            case 6: //Miles2
                result = givenValue * (2.490977f * Mathf.Pow (10, -10));
                break;

            case 7: //acre
                result = givenValue * (2f * Mathf.Pow (10, -7));
                break;

            case 8: //yard2
                result = givenValue / 1296f;
                break;

            case 9: //feet2
                result = givenValue / 144f;
                break;
            case 10: //Inch2
                result = givenValue;
                break;

            case 11: //square nautical mile
                result = givenValue / (5316366522.54f);
                break;
            case 12: //dunam (middle east)
                result = givenValue * (6.4516f * Mathf.Pow (10, -7));
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 0.0001952f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 0.0001952f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * (2f * Mathf.Pow (10, -7));
                break;
        }

        resultString = result.ToString ();

    }

    void nMiles2 () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * 3.429904f;
                break;

            case 2: //Meter2
                result = givenValue * (3.429904f * Mathf.Pow (10, 6));
                break;

            case 3: //Centimeter2
                result = givenValue * (3.429904f * Mathf.Pow (10, 10));
                break;

            case 4: //Milimeter2
                result = givenValue * (3.429904f * Mathf.Pow (10, 12));
                break;

            case 5: //hectare
                result = givenValue * (3.429904f * Mathf.Pow (10, 2));
                break;
            case 6: //Miles2
                result = givenValue * 1.325986786715f;
                break;

            case 7: //acre
                result = givenValue * (848.63154189319f);
                break;

            case 8: //yard2
                result = givenValue * 4107410.854417f;
                break;

            case 9: //feet2
                result = givenValue * 36966388.603652f;
                break;
            case 10: //Inch2
                result = givenValue * 5323160164.9833f;
                break;

            case 11: //square nautical mile
                result = givenValue * (2.708616860586f * Mathf.Pow (10, -8));
                break;
            case 12: //dunam (middle east)
                result = givenValue * (3.429904f * Mathf.Pow (10, 3));
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 1037542.21f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 1037542.21f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * (2.36f * Mathf.Pow (10, -5));
                break;
        }

        resultString = result.ToString ();

    }

    void dunam () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * (9.290304f * Mathf.Pow (10, -8));
                break;

            case 2: //Meter2
                result = givenValue * (9.290304f * Mathf.Pow (10, -2));
                break;

            case 3: //Centimeter2
                result = givenValue * (9.290304f * Mathf.Pow (10, 2));
                break;

            case 4: //Milimeter2
                result = givenValue * (9.290304f * Mathf.Pow (10, 4));
                break;

            case 5: //hectare
                result = givenValue * (9.290304f * Mathf.Pow (10, -6));
                break;
            case 6: //Miles2
                result = givenValue / 27878400f;
                break;

            case 7: //acre
                result = givenValue * (2.29568411f * Mathf.Pow (10, -5));
                break;

            case 8: //yard2
                result = givenValue / 9f;
                break;

            case 9: //feet2
                result = givenValue;
                break;
            case 10: //Inch2
                result = givenValue * 144f;
                break;

            case 11: //square nautical mile
                result = givenValue * (2.708616860586f * Mathf.Pow (10, -8));
                break;
            case 12: //dunam (middle east)
                result = givenValue * (9.290304f * Mathf.Pow (10, -5));
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 0.0281031696f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 0.0281031696f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * (2.36f * Mathf.Pow (10, -5));
                break;
        }

        resultString = result.ToString ();

    }

    void tsubo () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * (3.3058f * Mathf.Pow (10, -6));
                break;

            case 2: //Meter2
                result = givenValue * (3.3058f);
                break;

            case 3: //Centimeter2
                result = givenValue * (3.3058f * Mathf.Pow (10, 4));
                break;

            case 4: //Milimeter2
                result = givenValue * (3.3058f * Mathf.Pow (10, 6));
                break;

            case 5: //hectare
                result = givenValue * (3.3058f * Mathf.Pow (10, 2));
                break;
            case 6: //Miles2
                result = givenValue * (1.2763765157096f * Mathf.Pow (10, -6));
                break;

            case 7: //acre
                result = givenValue * (8.168802478959f * Mathf.Pow (10, -4));
                break;

            case 8: //yard2
                result = givenValue * 3.95f;
                break;

            case 9: //feet2
                result = givenValue * 35.58f;
                break;
            case 10: //Inch2
                result = givenValue * 5124f;
                break;

            case 11: //square nautical mile
                result = givenValue * (2.708616860586f * Mathf.Pow (10, -8));
                break;
            case 12: //dunam (middle east)
                result = givenValue * 0.0033058f;
                break;

            case 13: //tsubo (japanese)
                result = givenValue;
                break;

            case 14: //pyeong (korean)
                result = givenValue;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * 0.00084117048346056f;
                break;
        }

        resultString = result.ToString ();

    }

    void pyeong () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * (3.3058f * Mathf.Pow (10, -6));
                break;

            case 2: //Meter2
                result = givenValue * (3.3058f);
                break;

            case 3: //Centimeter2
                result = givenValue * (3.3058f * Mathf.Pow (10, 4));
                break;

            case 4: //Milimeter2
                result = givenValue * (3.3058f * Mathf.Pow (10, 6));
                break;

            case 5: //hectare
                result = givenValue * (3.3058f * Mathf.Pow (10, 2));
                break;
            case 6: //Miles2
                result = givenValue * (1.2763765157096f * Mathf.Pow (10, -6));
                break;

            case 7: //acre
                result = givenValue * (8.168802478959f * Mathf.Pow (10, -4));
                break;

            case 8: //yard2
                result = givenValue * 3.95f;
                break;

            case 9: //feet2
                result = givenValue * 35.58f;
                break;
            case 10: //Inch2
                result = givenValue * 5124f;
                break;

            case 11: //square nautical mile
                result = givenValue * (2.708616860586f * Mathf.Pow (10, -8));
                break;
            case 12: //dunam (middle east)
                result = givenValue * 0.0033058f;
                break;

            case 13: //tsubo (japanese)
                result = givenValue;
                break;

            case 14: //pyeong (korean)
                result = givenValue;
                break;

            case 15: //cuerda (spanish)
                result = givenValue * 0.00084117048346056f;
                break;
        }

        resultString = result.ToString ();

    }

    void cuerda () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //Kilometer2
                result = givenValue * (0.00393f);
                break;

            case 2: //Meter2
                result = givenValue * (3.93f * Mathf.Pow (10, 4));
                break;

            case 3: //Centimeter2
                result = givenValue * (3.93f * Mathf.Pow (10, 8));
                break;

            case 4: //Milimeter2
                result = givenValue * (3.93f * Mathf.Pow (10, 10));
                break;

            case 5: //hectare
                result = givenValue * (3.93f);
                break;
            case 6: //Miles2
                result = givenValue * (1.5173814830718f * Mathf.Pow(10, -3));
                break;

            case 7: //acre
                result = givenValue * 0.97112329065003f;
                break;

            case 8: //yard2
                result = givenValue * 4700.24f;
                break;

            case 9: //feet2
                result = givenValue * 42302.17f;
                break;
            case 10: //Inch2
                result = givenValue * 6091512.18f;
                break;

            case 11: //square nautical mile
                result = givenValue * (1.1458036531531f * Mathf.Pow (10, -3));
                break;
            case 12: //dunam (middle east)
                result = givenValue * 3.93f;
                break;

            case 13: //tsubo (japanese)
                result = givenValue * 1182.82f;
                break;

            case 14: //pyeong (korean)
                result = givenValue * 1182.82f;
                break;

            case 15: //cuerda (spanish)
                result = givenValue;
                break;
        }

        resultString = result.ToString ();

    }
}