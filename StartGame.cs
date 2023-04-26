using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour
{
    public string Level;
    public string Level2;
    bool isStarting;
    public GameObject Cam;
    public GameObject CamPos;

    // Update is called once per frame
    public void OnSClick()
    {
        isStarting = true;
    }
    public void OnCClick()
    {
        SceneManager.LoadScene(Level2);
    }
    public void OnMClick()
    {
        LoadLevel.mainMenu();
    }
    void Update()
    {
        if (isStarting == true)
        {
            Cam.transform.position = Vector3.MoveTowards(Cam.transform.position, CamPos.transform.position, .8f);
            Cam.transform.eulerAngles = Vector3.MoveTowards(Cam.transform.eulerAngles, CamPos.transform.eulerAngles, 2f);
            if (Cam.transform.position == CamPos.transform.position && Cam.transform.eulerAngles == CamPos.transform.eulerAngles)
            {
                isStarting = false;
                SceneManager.LoadScene(Level);
            }
        }
    }
}
