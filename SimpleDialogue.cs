using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class SimpleDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI results;
    public GameObject advance;
    public TextAsset cpierrediag;
    public GameObject cpierrepic;
    string[] currentText;
    public static int dseq = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (dseq == 20)
        {
            cpierrepic.SetActive(false);
        }
        else
        {
            currentText = (cpierrediag.text.Split('\n'));
            dialogue.text = currentText[dseq];
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (dseq == 19)
        {
            dseq = 20;
            this.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && dseq < 3)
        {
            dseq++;
            dialogue.text = currentText[dseq];
        }
        else if (Betting.bet > 0 && dseq < 4)
        {
            dialogue.text = "OK, Don't listen to me, I guess you've played this before.";
            advance.SetActive(false);
            StartCoroutine(WaitForSeconds());
        }
        else if (Input.GetKeyDown(KeyCode.E) && dseq == 3)
        {
            advance.SetActive(false);
            dseq++;
            dialogue.text = currentText[dseq];
        }
        else if (Betting.bet > 0 && dseq == 4)
        {
            dseq++;
            dialogue.text = currentText[dseq];
        }
        else if (RouletteSpin.canSpin == false && dseq == 5)
        {
            dseq++;
            dialogue.text = currentText[dseq];
        }
        else if (Input.GetKeyDown(KeyCode.Space) && dseq == 6)
        {
            dseq++;
            dialogue.text = currentText[dseq];
        }
        else if (Results.spinC == true && dseq == 7)
        {
            advance.SetActive(true);
            dseq++;
            dialogue.text = currentText[dseq];
        }
        else if (Input.GetKeyDown(KeyCode.E) && dseq == 8)
        {
            if (results.text == "You LOST!")
            {
                dseq += 4;
                dialogue.text = currentText[dseq];
            }
            else if (results.text == "You Win!")
            {
                dseq++;
                dialogue.text = currentText[dseq];
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) && dseq >= 9 && dseq < 18)
        {
            dseq++;
            dialogue.text = currentText[dseq];
        }
        else if (dseq == 18)
        {
            dseq = 19;
        }
    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(5);
        dseq = 20;
        advance.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
