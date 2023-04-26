using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
using System.Text;

public class EnemyAIDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI tenemymoney;
    public TextMeshProUGUI dresults;
    public GameObject advance;
    public GameObject results;
    public GameObject enemyChip;
    public GameObject genemy;
    public GameObject gresults;
    public GameObject mmarleypic;
    public TextAsset mmarleydiag;
    public static string enemyBet;
    public static float emoney = 500;
    public static float ebet;
    public static bool eReset;
    public static bool marBet;
    float betlcl;
    string[] currentText;
    public static int eseq = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentText = (mmarleydiag.text.Split('\n'));
        if (eseq > 0)
        {
            mmarleypic.SetActive(true);
            genemy.SetActive(true);
            dialogue.text = currentText[eseq];
            RouletteSpin.canSpin = false;
            Betting.canBet = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (SimpleDialogue.dseq == 20)
        {
            if (eReset == true)
            {
                genemy.SetActive(true);
                dialogue.text = currentText[eseq];
                eReset = false;
            }
            tenemymoney.text = emoney.ToString();
            if (Input.GetKeyDown(KeyCode.E) && eseq < 2)
            {
                eseq++;
                dialogue.text = currentText[eseq];
            }
            else if (Input.GetKeyDown(KeyCode.E) && eseq == 2)
            {
                eseq++;
                dialogue.text = currentText[eseq];
                advance.SetActive(false);
                marBet = true;
                Betting.canBet = true;
            }
            else if (Betting.bet > 0 && eseq == 3)
            {
                eseq++;
                dialogue.text = currentText[eseq];
                advance.SetActive(true);
            }
            else if (Betting.bet == 0 && eseq == 4)
            {
                eseq = 2;
                dialogue.text = "What're ya tryna pull on me...";
            }
            else if  (Input.GetKeyDown(KeyCode.E) && eseq == 4)
            {
                ebet = Betting.bet;
                int bigbet = Random.Range(0, 36);
                Betting.bet += ebet;
                emoney -= ebet;
                if (Betting.bbTxt == "Bet (BLACK)")
                {
                    enemyBet = "Bet (RED)";
                    ChipsLocator.echipMove = true;
                }
                else if (Betting.bbTxt == "Bet (RED)")
                {
                    enemyBet = "Bet (BLACK)";
                    ChipsLocator.echipMove = true;
                }
                else if (Betting.bbTxt == "Bet (ODD)")
                {
                    enemyBet = "Bet (EVEN)";
                    ChipsLocator.echipMove = true;
                }
                else if (Betting.bbTxt == "Bet (EVEN)")
                {
                    enemyBet = "Bet (ODD)";
                    ChipsLocator.echipMove = true;
                }
                else if (Betting.bbTxt == "Bet (1-18)")
                {
                    enemyBet = "Bet (19-36)";
                    ChipsLocator.echipMove = true;
                }
                else if (Betting.bbTxt == "Bet (19-36)")
                {
                    enemyBet = "Bet (1-18)";
                    ChipsLocator.echipMove = true;
                }
                else
                {
                    enemyChip.transform.position = new Vector3(-59.97f, 7.815f, 7.49f);
                    StringBuilder sb = new StringBuilder("Bet (", 8);
                    if (bigbet < 10)
                    {
                        sb.Append("0");
                    }
                    sb.Append(bigbet);
                    sb.Append(")");
                    enemyBet = sb.ToString();
                    Debug.Log(enemyBet);
                    ChipsLocator.echipMove = true;
                }
                eseq++;
                dialogue.text = currentText[eseq];
                advance.SetActive(false);
                RouletteSpin.canSpin = true;
                Betting.canBet = false;
            }
            else if (RouletteSpin.canSpin == false && eseq == 5)
            {
                eseq++;
                dialogue.text = currentText[eseq];
            }
            else if (Results.spinC == true && eseq == 6)
            {
                betlcl = Betting.bet;
                if (AnnounceRoll.roll[4] == enemyBet[5] && AnnounceRoll.roll[5] == enemyBet[6])
                {
                    eseq = 16;
                    dialogue.text = currentText[eseq];
                    emoney += betlcl;
                }
                else if (AnnounceRoll.roll[6] == enemyBet[5] && AnnounceRoll.roll[7] == enemyBet[6])
                {
                    eseq = 18;
                    dialogue.text = currentText[eseq];
                    emoney += betlcl;
                }
                else if (enemyBet[5] == 'O' && (AnnounceRoll.roll[7] == '1' || AnnounceRoll.roll[7] == '3' || AnnounceRoll.roll[7] == '5' || AnnounceRoll.roll[7] == '7' || AnnounceRoll.roll[7] == '9')) //Odd
                {
                    eseq = 20;
                    dialogue.text = currentText[eseq];
                    emoney += betlcl;
                }
                else if (enemyBet[5] == 'E' && (AnnounceRoll.roll[7] == '0' || AnnounceRoll.roll[7] == '2' || AnnounceRoll.roll[7] == '4' || AnnounceRoll.roll[7] == '6' || AnnounceRoll.roll[7] == '8')) //Even
                {
                    eseq = 14;
                    dialogue.text = currentText[eseq];
                    emoney += betlcl;
                }
                else if (enemyBet[6] == '-' && (AnnounceRoll.roll[6] == '0' || (AnnounceRoll.roll[6] == '1' && AnnounceRoll.roll[7] != '9')))//1-18
                {
                    eseq = 18;
                    dialogue.text = currentText[eseq];
                    emoney += betlcl;
                }
                else if (enemyBet[7] == '-' && (AnnounceRoll.roll[6] == '2' || AnnounceRoll.roll[6] == '3' || (AnnounceRoll.roll[6] == '1' && AnnounceRoll.roll[7] == '9')))//19-36
                {
                    eseq = 14;
                    dialogue.text = currentText[eseq];
                    emoney += betlcl;
                }
                else
                {
                    eseq = 17;
                    dialogue.text = currentText[eseq];
                }
            }
            else if (results.activeInHierarchy && emoney <= 0 && dresults.text == "You Win!" && Betting.score > 0)
            {
                eseq = 19;
                dialogue.text = currentText[eseq];
                gresults.SetActive(false);
                StartCoroutine(WaitForSeconds());
            }
        }
    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Win");
    }
}
