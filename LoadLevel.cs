using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LoadLevel : MonoBehaviour
{
    public string Loselevel;

    // Update is called once per frame
    public static void RouletteReset()
    {
        Betting.canBet = true;
        RouletteSpin.canSpin = false;
        SimpleDialogue.dseq = 20;
        RouletteSpin.isResetting = true;
        EnemyAIDialogue.eReset = true;
        ChipsLocator.cReset = true;
        BallLaunch.bReset = true;
        if (EnemyAIDialogue.eseq > 0)
        {
            EnemyAIDialogue.eseq = 3;
        }
        else if (EnemyAIDialogue.eseq == 0)
        {
            Betting.canBet = false;
        }
        Results.spinC = false;
    }
    public static void mainMenu()
    {
        Betting.canBet = true;
        EnemyAIDialogue.marBet = false;
        RouletteSpin.canSpin = false;
        SimpleDialogue.dseq = 0;
        EnemyAIDialogue.eseq = 0;
        Betting.bet = 0;
        Betting.score = 500;
        EnemyAIDialogue.emoney = 500;
        Results.spinC = false;
        SceneManager.LoadScene("Menu");
    }
    void Update()
    {
        if ((Betting.score == 0 && Betting.bet == 0) || (Betting.score <= -1000 && Betting.bet == 0))
        {
            SceneManager.LoadScene(Loselevel);
        }
    }
}
