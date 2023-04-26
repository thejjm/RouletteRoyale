using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Unbet : MonoBehaviour
{
    public static bool chipMove;
    public GameObject fChips;
    public GameObject tChips;
    public GameObject twChips;
    public GameObject fiChips;
    public GameObject hChips;
    public GameObject fhChips;
    string chipsid;
    public void OnUnbetting()
    {
        if (Betting.bet == 0)
        {
            fChips.transform.localPosition = new Vector3(0, 0, -0.304f);
            tChips.transform.localPosition = new Vector3(0.313f, 0, 0);
            twChips.transform.localPosition = new Vector3(0.006f, 0, 0);
            fiChips.transform.localPosition = new Vector3(-0.292f, 0, 0);
            hChips.transform.localPosition = new Vector3(0.194f, 0, 0.264f);
            fhChips.transform.localPosition = new Vector3(-0.164f, 0, 0.264f);
        }
        else if (Betting.bet == 100)
        {
            tChips.transform.localPosition = new Vector3(0.313f, 0, 0);
        }
        else if (Betting.bet == 200)
        {
            twChips.transform.localPosition = new Vector3(0.006f, 0, 0);
        }
        else if (Betting.bet == 300)
        {
            fiChips.transform.localPosition = new Vector3(-0.292f, 0, 0);
        }
        else if (Betting.bet == 400)
        {
            hChips.transform.localPosition = new Vector3(0.194f, 0, 0.264f);
        }
        else if (Betting.bet == 500)
        {
            fhChips.transform.localPosition = new Vector3(-0.164f, 0, 0.264f);
        }
    }
}
