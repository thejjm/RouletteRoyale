using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Betting : MonoBehaviour
{
    public TextMeshProUGUI betBox;
    public TextMeshProUGUI chipBet;
    public TextMeshProUGUI money;
    public static string bbTxt;
    public static float bet;
    public static float score = 500;
    public static Vector3 buttonPos = new Vector3 (-49.34498f, 7.815f, 13.91339f);
    public static bool canBet = true;
    public void ReWrite()
    {
      if (canBet == true && score != 0)
      {
         betBox.text = EventSystem.current.currentSelectedGameObject.name;
         bbTxt = EventSystem.current.currentSelectedGameObject.name;
         bet += 100;
         score -= 100;
         ChipsLocator.chipMove = true;
        if (EnemyAIDialogue.marBet == false)
        {
            RouletteSpin.canSpin = true;
        }
      }
    }
    public void Unbet()
    {
        if (canBet == true && bet > 0)
        {
            bet -= 100;
            score += 100;
            ChipsLocator.chipMove = true;
            if (bet == 0)
            {
                RouletteSpin.canSpin = false;
            }
        }
    }
    public void badodds()
    {
        ErrorHandler.eCode = 2;
    }
    void Update()
    {
        chipBet.text = bet.ToString();
        money.text = score.ToString();
    }
}
