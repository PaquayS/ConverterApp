using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorTime : MonoBehaviour {
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
                    millenium ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 2:
                    century ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 3:
                    decade ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 4:
                    normalYear ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 5:
                    leapYear ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 6:
                    week ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 7:
                    day ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;

                case 8:
                    hour ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;
                case 9:
                    minute ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;
                case 10:
                    second ();
                    valueWanted.text = resultString;
                    convertValue = false;
                    break;
            }
        }
    }
    public void convertValues () {
        convertValue = true;
        givenValue = float.Parse (valueGiven.text);
    }

    void millenium () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue;
                break;

            case 2: //century
                result = givenValue * 10f;
                break;

            case 3: //decade
                result = givenValue * 100f;
                break;

            case 4: //normalYear
                result = givenValue * 1000f;
                break;

            case 5: //leapYear
                result = givenValue * 1000f;
                break;

            case 6: //week
                result = givenValue * 52177.457f;
                break;

            case 7: //day
                result = givenValue * 365242.199f;
                break;

            case 8: //hour
                result = givenValue * 365242.199f * 24f;
                break;

            case 9: //minute
                result = givenValue * 365242.199f * 24f * 60f;
                break;

            case 10: //second
                result = givenValue * 365242.199f * 24f * 60f * 60f;
                break;
        }
        resultString = result.ToString ();
    }

    void century () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / 10f;
                break;

            case 2: //century
                result = givenValue;
                break;

            case 3: //decade
                result = givenValue * 10f;
                break;

            case 4: //normalYear
                result = givenValue * 100f;
                break;

            case 5: //leapYear
                result = givenValue * 100f;
                break;

            case 6: //week
                result = givenValue * 5217.7457f;
                break;

            case 7: //day
                result = givenValue * 36524.2199f;
                break;

            case 8: //hour
                result = givenValue * 36524.2199f * 24f;
                break;

            case 9: //minute
                result = givenValue * 36524.2199f * 24f * 60f;
                break;

            case 10: //second
                result = givenValue * 36524.2199f * 24f * 60f * 60f;
                break;
        }
        resultString = result.ToString ();

    }

    void decade () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / 100f;
                break;

            case 2: //century
                result = givenValue / 10f;
                break;

            case 3: //decade
                result = givenValue;
                break;

            case 4: //normalYear
                result = givenValue * 10f;
                break;

            case 5: //leapYear
                result = givenValue * 10f;
                break;

            case 6: //week
                result = givenValue * 521.77457f;
                break;

            case 7: //day
                result = givenValue * 3652.42199f;
                break;

            case 8: //hour
                result = givenValue * 3652.42199f * 24f;
                break;

            case 9: //minute
                result = givenValue * 3652.42199f * 24f * 60f;
                break;

            case 10: //second
                result = givenValue * 3652.42199f * 24f * 60f * 60f;
                break;
        }
        resultString = result.ToString ();

    }

    void normalYear () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / 1000f;
                break;

            case 2: //century
                result = givenValue / 100f;
                break;

            case 3: //decade
                result = givenValue / 10f;
                break;

            case 4: //normalYear
                result = givenValue;
                break;

            case 5: //leapYear
                result = givenValue * 0.99726775956f;
                break;

            case 6: //week
                result = givenValue * 52.177457f;
                break;

            case 7: //day
                result = givenValue * 365f;
                break;

            case 8: //hour
                result = givenValue * 365f * 24f;
                break;

            case 9: //minute
                result = givenValue * 365f * 24f * 60f;
                break;

            case 10: //second
                result = givenValue * 365f * 24f * 60f * 60f;
                break;
        }
        resultString = result.ToString ();

    }

    void leapYear () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / 1000f;
                break;

            case 2: //century
                result = givenValue / 100f;
                break;

            case 3: //decade
                result = givenValue / 10f;
                break;

            case 4: //normalYear
                result = givenValue * 1.00273972603f;
                break;

            case 5: //leapYear
                result = givenValue;
                break;

            case 6: //week
                result = givenValue * 52.2857142857f;
                break;

            case 7: //day
                result = givenValue * 366f;
                break;

            case 8: //hour
                result = givenValue * 366f * 24f;
                break;

            case 9: //minute
                result = givenValue * 366f * 24f * 60f;
                break;

            case 10: //second
                result = givenValue * 366f * 24f * 60f * 60f;
                break;
        }
        resultString = result.ToString ();

    }

    void week () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / 52177.457f;
                break;

            case 2: //century
                result = givenValue / 5217.7457f;
                break;

            case 3: //decade
                result = givenValue / 521.77457f;
                break;

            case 4: //normalYear
                result = givenValue / 52.1428571429f;
                break;

            case 5: //leapYear
                result = givenValue / 52.2857142857f;
                break;

            case 6: //week
                result = givenValue;
                break;

            case 7: //day
                result = givenValue * 7f;
                break;

            case 8: //hour
                result = givenValue * 7f * 24f;
                break;

            case 9: //minute
                result = givenValue * 7f * 24f * 60f;
                break;

            case 10: //second
                result = givenValue * 7f * 24f * 60f * 60f;
                break;
        }
        resultString = result.ToString ();

    }

    void day () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / (7f * 52177.457f);
                break;

            case 2: //century
                result = givenValue / (5217.7457f * 7f);
                break;

            case 3: //decade
                result = givenValue / (521.77457f * 7f);
                break;

            case 4: //normalYear
                result = givenValue / (52.1428571429f * 7f);
                break;

            case 5: //leapYear
                result = givenValue / (52.2857142857f * 7f);
                break;

            case 6: //week
                result = givenValue / 7f;
                break;

            case 7: //day
                result = givenValue;
                break;

            case 8: //hour
                result = givenValue * 24f;
                break;

            case 9: //minute
                result = givenValue * 24f * 60f;
                break;

            case 10: //second
                result = givenValue * 24f * 60f * 60f;
                break;
        }
        resultString = result.ToString ();

    }

    void hour () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / (24f * 7f * 52177.457f);
                break;

            case 2: //century
                result = givenValue / (5217.7457f * 7f * 24f);
                break;

            case 3: //decade
                result = givenValue / (521.77457f * 7f * 24f);
                break;

            case 4: //normalYear
                result = givenValue / (52.1428571429f * 7f * 24f);
                break;

            case 5: //leapYear
                result = givenValue / (52.2857142857f * 7f * 24f);
                break;

            case 6: //week
                result = givenValue / (7f * 24f);
                break;

            case 7: //day
                result = givenValue / 24f;
                break;

            case 8: //hour
                result = givenValue;
                break;

            case 9: //minute
                result = givenValue * 60f;
                break;

            case 10: //second
                result = givenValue * 60f * 60f;
                break;
        }
        resultString = result.ToString ();

    }

    void minute () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / (24f * 7f * 52177.457f * 60f);
                break;

            case 2: //century
                result = givenValue / (5217.7457f * 7f * 24f * 60f);
                break;

            case 3: //decade
                result = givenValue / (521.77457f * 7f * 24f * 60f);
                break;

            case 4: //normalYear
                result = givenValue / (52.1428571429f * 7f * 24f * 60f);
                break;

            case 5: //leapYear
                result = givenValue / (52.2857142857f * 7f * 24f * 60f);
                break;

            case 6: //week
                result = givenValue / (7f * 24f * 60f);
                break;

            case 7: //day
                result = givenValue / (24f * 60f);
                break;

            case 8: //hour
                result = givenValue / 60f;
                break;

            case 9: //minute
                result = givenValue;
                break;

            case 10: //second
                result = givenValue * 60f;
                break;
        }
        resultString = result.ToString ();

    }

    void second () {
        int unitWantedValue = unitWanted.value + 1;
        switch (unitWantedValue) {
            case 1: //millenium
                result = givenValue / (24f * 7f * 52177.457f * 60f * 60f);
                break;

            case 2: //century
                result = givenValue / (5217.7457f * 7f * 24f * 60f * 60f);
                break;

            case 3: //decade
                result = givenValue / (521.77457f * 7f * 24f * 60f * 60f);
                break;

            case 4: //normalYear
                result = givenValue / (52.1428571429f * 7f * 24f * 60f * 60f);
                break;

            case 5: //leapYear
                result = givenValue / (52.2857142857f * 7f * 24f * 60f * 60f);
                break;

            case 6: //week
                result = givenValue / (7f * 24f * 60f * 60f);
                break;

            case 7: //day
                result = givenValue / (24f * 60f * 60f);
                break;

            case 8: //hour
                result = givenValue / 3600f;
                break;

            case 9: //minute
                result = givenValue / 60f;
                break;

            case 10: //second
                result = givenValue;
                break;
        }
        resultString = result.ToString ();

    }
}