using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnnounceRoll : MonoBehaviour
{
    public TextMeshProUGUI dBox;
    public static string roll;
    // Start is called before the first frame update

    void OnTriggerEnter (Collider other)
    {
        dBox.text = other.gameObject.name;
        roll = other.gameObject.name;
    }
    void Update()
    {
        if (this.gameObject.transform.position.y < 0 || this.gameObject.transform.position.x < -50)
        {
            ErrorHandler.eCode = 1;
        }
    }
}
