using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ErrorHandler : MonoBehaviour
{
    public static int eCode = 0;
    public GameObject pic3;
    public TextMeshProUGUI edialogue;
    public GameObject adv;
    public GameObject results;
    public string leftover;
    bool left;
    // Start is called before the first frame update
    void Update()
    {
        if (eCode > 0)
        {
            pic3.SetActive(true);
            errorevent();
        }
    }

    // Update is called once per frame
    void errorevent()
    {
        if (eCode == 1)
        {
            edialogue.text = "WOW! you boosted it right outta the wheel. I got it though, just try to be more gentle next time.";
            adv.SetActive(true);
            results.SetActive(false);
            if (Input.GetKeyDown(KeyCode.E))
            {
                eCode = 0;
                pic3.SetActive(false);
                ERouletteReset();
                EnemyAIDialogue.eseq = 5;
                RouletteSpin.isSpinning = true;
            }
        }
        else if (eCode == 2)
        {
            if (left == false)
            {
                leftover = edialogue.text;
                left = true;
            }
            Debug.Log(leftover);
            edialogue.text = "I wouldn't bet that. Your odd's wouldn't be good. Try 1-18, thats better odds for ya.";
            adv.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                eCode = 0;
                pic3.SetActive(false);
                edialogue.text = leftover;
                left = false;
            }
        }
    }
    public void ERouletteReset()
    {
        SceneManager.LoadScene("Roulette");
        if (EnemyAIDialogue.eseq > 0)
        {
            EnemyAIDialogue.eseq = 3;
        }
        Results.spinC = false;
    }
}
