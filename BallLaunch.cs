using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public float speed = 100f;
    public static bool bReset;
    bool canBoost = false;
    // Update is called once per frame
    void Update()
    {
        if (RouletteSpin.isSpinning == true)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().AddForce(-transform.right * speed);
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
            canBoost = true;
        }
        else if (canBoost == true && Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
            canBoost= false;
        }
        if (bReset == true)
        {
            GetComponent<Rigidbody>().isKinematic= true;
            this.gameObject.transform.position = new Vector3 (-42.6f, 8.3f, 12.3f);
            this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            bReset = false;
        }
    }
}
