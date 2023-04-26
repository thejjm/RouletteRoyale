using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class RouletteSpin : MonoBehaviour

{
    public AudioClip ballRoll;
    Vector3 mRotation;
    float mouseZ;
    public static bool isSpinning = false;
    public static bool canSpin = false;
    public Rigidbody RBall;
    public GameObject rouletteWheel;
    public GameObject results;
    public GameObject bets;
    public static bool isResetting;
    private void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = Vector3.zero;
        GetComponent<Rigidbody>().inertiaTensorRotation = Quaternion.identity;
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Mouse.current.position.ReadValue();
        mousePoint.z = rouletteWheel.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        if (canSpin == true)
        {
            Vector3 wMouse = GetMouseAsWorldPoint();
            mouseZ = (wMouse.x * 20) + (wMouse.z * 20);
            mRotation = new Vector3(0, mouseZ, 0);
            transform.eulerAngles = mRotation;
        }
    }
    void OnMouseUp()
    {
        if (canSpin == true)
        {
            isSpinning = true;
            GetComponent<Rigidbody>().freezeRotation = false;
            RBall.constraints = RigidbodyConstraints.None;
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = ballRoll;
            audio.Play();
        }
    }
    void Update()
    {
        
        if (isSpinning == true)
        {
            GetComponent<Rigidbody>().AddRelativeTorque(0, -1000 ,0);
            isSpinning = false;
            Betting.canBet = false;
            canSpin = false;
            StartCoroutine(WaitForSeconds());
        }
        if (isResetting == true)
        {
            RBall.constraints = RigidbodyConstraints.None;
            results.SetActive(false);
            bets.SetActive(true);
        }
    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(10);
        RBall.constraints = RigidbodyConstraints.FreezeAll;
        results.SetActive(true);
        bets.SetActive(false);
        Results.spinC = true;
    }
}
