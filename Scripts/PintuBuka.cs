using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PintuBuka : MonoBehaviour
{
    public float jarakDariPemain;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject engselPintu;
    public GameObject ekstraCrossHair;
    public AudioSource pintuCreakySound;
    private bool pintuTerbuka = false;

    void Update()
    {
        jarakDariPemain = PemainCastingRay.targetKeObjek;
    }
    void togglePintu()
    {
        pintuTerbuka = !pintuTerbuka;
    }

    private void OnMouseOver()
    {
        if (jarakDariPemain <= 2)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            actionText.GetComponent<Text>().text = "Buka/Tutup pintu";
            ekstraCrossHair.SetActive(true);
        }

        if (Input.GetButtonDown("Action") && jarakDariPemain <= 2.5)
        {

            actionDisplay.SetActive(false);
            actionText.SetActive(false);
            pintuCreakySound.Play();
            if (!pintuTerbuka)
            {
            engselPintu.GetComponent<Animation>().Play("DoorAnim1");
            }if (pintuTerbuka)
            {
            engselPintu.GetComponent<Animation>().Play("DoorAnim2");
            }
            togglePintu();
            
            //this.GetComponent<BoxCollider>().enabled = false;
            
        }
    }

    private void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
        ekstraCrossHair.SetActive(false);
    }
}
