using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject pic;
    public GameObject pic2;
    public AudioClip otherClip;
    public static bool fSpinC;

    // Update is called once per frame
    void Update()
    {
        if (RouletteSpin.isResetting == true)
        {
            pic.gameObject.SetActive(false);
            pic2.gameObject.SetActive(true);
            dialogue.gameObject.SetActive(true);
            if (fSpinC == false)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
                fSpinC = true;
            }
            RouletteSpin.isResetting = false;
        }
    }
}
