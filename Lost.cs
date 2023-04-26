using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lost : MonoBehaviour
{
    public string getBack;
    public TextMeshProUGUI dloselose;
    public GameObject gameover;
    public GameObject adv;
    // Start is called before the first frame update
    void Start()
    {
        if (Betting.score < 0)
        {
            dloselose.text = "Alright you are DONE! Get out of my casino!";
            gameover.SetActive(true);
            adv.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Betting.score == 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Betting.score = -500;
                SceneManager.LoadScene(getBack);
                EnemyAIDialogue.marBet = true;
                EnemyAIDialogue.eseq = 3;
            }
        }
    }
}
