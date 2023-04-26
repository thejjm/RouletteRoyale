using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChipsLocator : MonoBehaviour
{
    public AudioClip chipsm;
    public static bool chipMove;
    public static bool echipMove;
    public static bool cReset;
    public GameObject fChips;
    public GameObject tChips;
    public GameObject twChips;
    public GameObject fiChips;
    public GameObject hChips;
    public GameObject fhChips;
    public GameObject efChips;
    public GameObject etChips;
    public GameObject etwChips;
    public GameObject efiChips;
    public GameObject ehChips;
    public GameObject efhChips;
    public static Vector3 eChipPos;
    string chipsid;
    // Start is called before the first frame update
    void Start()
    {
        chipsid = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (chipMove == true && EventSystem.current.currentSelectedGameObject.name == chipsid)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = chipsm;
            audio.Play();
            Betting.buttonPos = this.gameObject.transform.position;
            if (Betting.bet == 100)
            {
                fChips.transform.position = new Vector3(Betting.buttonPos.x, 7.815f, Betting.buttonPos.z - 0.304f);
            }
            else if (Betting.bet == 200)
            {
                fChips.transform.position = new Vector3(Betting.buttonPos.x, 7.815f, Betting.buttonPos.z - 0.304f);
                tChips.transform.position = new Vector3(Betting.buttonPos.x + 0.313f, 7.815f, Betting.buttonPos.z);
            }
            else if (Betting.bet == 300)
            {
                fChips.transform.position = new Vector3(Betting.buttonPos.x, 7.815f, Betting.buttonPos.z - 0.304f);
                tChips.transform.position = new Vector3(Betting.buttonPos.x + 0.313f, 7.815f, Betting.buttonPos.z);
                twChips.transform.position = new Vector3(Betting.buttonPos.x + 0.006f, 7.815f, Betting.buttonPos.z);
            }
            else if (Betting.bet == 400)
            {
                fChips.transform.position = new Vector3(Betting.buttonPos.x, 7.815f, Betting.buttonPos.z - 0.304f);
                tChips.transform.position = new Vector3(Betting.buttonPos.x + 0.313f, 7.815f, Betting.buttonPos.z);
                twChips.transform.position = new Vector3(Betting.buttonPos.x + 0.006f, 7.815f, Betting.buttonPos.z);
                fiChips.transform.position = new Vector3(Betting.buttonPos.x - 0.292f, 7.815f, Betting.buttonPos.z);
            }
            else if (Betting.bet == 500)
            {
                fChips.transform.position = new Vector3(Betting.buttonPos.x, 7.815f, Betting.buttonPos.z - 0.304f);
                tChips.transform.position = new Vector3(Betting.buttonPos.x + 0.313f, 7.815f, Betting.buttonPos.z);
                twChips.transform.position = new Vector3(Betting.buttonPos.x + 0.006f, 7.815f, Betting.buttonPos.z);
                fiChips.transform.position = new Vector3(Betting.buttonPos.x - 0.292f, 7.815f, Betting.buttonPos.z);
                hChips.transform.position = new Vector3(Betting.buttonPos.x + 0.194f, 7.815f, Betting.buttonPos.z + 0.264f);
            }
            else if (Betting.bet >= 600)
            {
                fChips.transform.position = new Vector3(Betting.buttonPos.x, 7.815f, Betting.buttonPos.z - 0.304f);
                tChips.transform.position = new Vector3(Betting.buttonPos.x + 0.313f, 7.815f, Betting.buttonPos.z);
                twChips.transform.position = new Vector3(Betting.buttonPos.x + 0.006f, 7.815f, Betting.buttonPos.z);
                fiChips.transform.position = new Vector3(Betting.buttonPos.x - 0.292f, 7.815f, Betting.buttonPos.z);
                hChips.transform.position = new Vector3(Betting.buttonPos.x + 0.194f, 7.815f, Betting.buttonPos.z + 0.264f);
                fhChips.transform.position = new Vector3(Betting.buttonPos.x - 0.164f, 7.815f, Betting.buttonPos.z + 0.264f);
            }
            chipMove = false;
        }
        if (EnemyAIDialogue.enemyBet == chipsid && echipMove == true)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = chipsm;
            audio.Play();
            eChipPos = this.gameObject.transform.position;
            if (EnemyAIDialogue.ebet == 100)
            {
                efChips.transform.position = new Vector3(eChipPos.x, 7.815f, eChipPos.z - 0.304f);
            }
            else if (EnemyAIDialogue.ebet == 200)
            {
                efChips.transform.position = new Vector3(eChipPos.x, 7.815f, eChipPos.z - 0.304f);
                etChips.transform.position = new Vector3(eChipPos.x + 0.313f, 7.815f, eChipPos.z);
            }
            else if (EnemyAIDialogue.ebet == 300)
            {
                efChips.transform.position = new Vector3(eChipPos.x, 7.815f, eChipPos.z - 0.304f);
                etChips.transform.position = new Vector3(eChipPos.x + 0.313f, 7.815f, eChipPos.z);
                etwChips.transform.position = new Vector3(eChipPos.x + 0.006f, 7.815f, eChipPos.z);
            }
            else if (EnemyAIDialogue.ebet == 400)
            {
                efChips.transform.position = new Vector3(eChipPos.x, 7.815f, eChipPos.z - 0.304f);
                etChips.transform.position = new Vector3(eChipPos.x + 0.313f, 7.815f, eChipPos.z);
                etwChips.transform.position = new Vector3(eChipPos.x + 0.006f, 7.815f, eChipPos.z);
                efiChips.transform.position = new Vector3(eChipPos.x - 0.292f, 7.815f, eChipPos.z);
            }
            else if (EnemyAIDialogue.ebet == 500)
            {
                efChips.transform.position = new Vector3(eChipPos.x, 7.815f, eChipPos.z - 0.304f);
                etChips.transform.position = new Vector3(eChipPos.x + 0.313f, 7.815f, eChipPos.z);
                etwChips.transform.position = new Vector3(eChipPos.x + 0.006f, 7.815f, eChipPos.z);
                efiChips.transform.position = new Vector3(eChipPos.x - 0.292f, 7.815f, eChipPos.z);
                ehChips.transform.position = new Vector3(eChipPos.x + 0.194f, 7.815f, eChipPos.z + 0.264f);
            }
            else if (EnemyAIDialogue.ebet >= 600)
            {
                efChips.transform.position = new Vector3(eChipPos.x, 7.815f, eChipPos.z - 0.304f);
                etChips.transform.position = new Vector3(eChipPos.x + 0.313f, 7.815f, eChipPos.z);
                etwChips.transform.position = new Vector3(eChipPos.x + 0.006f, 7.815f, eChipPos.z);
                efiChips.transform.position = new Vector3(eChipPos.x - 0.292f, 7.815f, eChipPos.z);
                ehChips.transform.position = new Vector3(eChipPos.x + 0.194f, 7.815f, eChipPos.z + 0.264f);
                efhChips.transform.position = new Vector3(eChipPos.x - 0.164f, 7.815f, eChipPos.z + 0.264f);
            }
            echipMove = false;
        }
        if (cReset == true)
        {
            fChips.transform.localPosition = new Vector3(0, 0, -0.304f);
            tChips.transform.localPosition = new Vector3(0.313f, 0, 0);
            twChips.transform.localPosition = new Vector3(0.006f, 0, 0);
            fiChips.transform.localPosition = new Vector3(-0.292f, 0, 0);
            hChips.transform.localPosition = new Vector3(0.194f, 0, 0.264f);
            fhChips.transform.localPosition = new Vector3(-0.164f, 0, 0.264f);
            efChips.transform.localPosition = new Vector3(0, 0, -0.304f);
            etChips.transform.localPosition = new Vector3(0.313f, 0, 0);
            etwChips.transform.localPosition = new Vector3(0.006f, 0, 0);
            efiChips.transform.localPosition = new Vector3(-0.292f, 0, 0);
            ehChips.transform.localPosition = new Vector3(0.194f, 0, 0.264f);
            efhChips.transform.localPosition = new Vector3(-0.164f, 0, 0.264f);
            cReset = false;
        }
    }
}
