using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public TextMeshProUGUI result;
    float scorelcl;
    float betlcl;
    public static bool spinC;

    void Update()
    {
        if (spinC == true)
        {
            scorelcl = Betting.score;
            betlcl = Betting.bet;
            Betting.bet = 0;
            if (AnnounceRoll.roll[4] == Betting.bbTxt[5] && AnnounceRoll.roll[5] == Betting.bbTxt[6]) //color
            {
                result.text = "You Win!";
                Betting.score = scorelcl + betlcl;
                Debug.Log("Scenario1");
            }
            else if (AnnounceRoll.roll[6] == Betting.bbTxt[5] && AnnounceRoll.roll[7] == Betting.bbTxt[6]) //number betting
            {
                result.text = "You Win!";
                betlcl += betlcl;
                Betting.score = scorelcl + betlcl;
                Debug.Log("Scenario2");
            }
            else if (Betting.bbTxt[5] == 'O' && (AnnounceRoll.roll[7] == '1' || AnnounceRoll.roll[7] == '3' || AnnounceRoll.roll[7] == '5' || AnnounceRoll.roll[7] == '7' || AnnounceRoll.roll[7] == '9')) //Odd
            {
                result.text = "You Win!";
                Betting.score = scorelcl + betlcl;
                Debug.Log("Scenario3");
            }
            else if (Betting.bbTxt[5] == 'E' && (AnnounceRoll.roll[7] == '0' || AnnounceRoll.roll[7] == '2' || AnnounceRoll.roll[7] == '4' || AnnounceRoll.roll[7] == '6' || AnnounceRoll.roll[7] == '8')) //Even
            {
                result.text = "You Win!";
                Betting.score = scorelcl + betlcl;
                Debug.Log("Scenario4");
            }
            else if (Betting.bbTxt[6] == '-' && (AnnounceRoll.roll[6] == '0' || (AnnounceRoll.roll[6] == '1' && AnnounceRoll.roll[7] != '9')))//1-18
            {
                result.text = "You Win!";
                Betting.score = scorelcl + betlcl;
                Debug.Log("Scenario5");
            }
            else if (Betting.bbTxt[7] == '-' && (AnnounceRoll.roll[6] == '2' || AnnounceRoll.roll[6] == '3' || (AnnounceRoll.roll[6] == '1' && AnnounceRoll.roll[7] == '9')))//19-36
            {
                result.text = "You Win!";
                Betting.score = scorelcl + betlcl;
                Debug.Log("Scenario6");
            }
            else
            {
                result.text = "You LOST!";
            }
            spinC = false;
        }
    }
}
