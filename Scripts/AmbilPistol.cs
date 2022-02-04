using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmbilPistol : MonoBehaviour
{
    public float jarakDariPemain;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject ekstraCrossHair;
    public GameObject markerTakeable;
    public GameObject pistolPalsu;
    public GameObject pistolAsli;



    void Update()
    {
        jarakDariPemain = PemainCastingRay.targetKeObjek;
    }
   

    private void OnMouseOver()
    {
        if (jarakDariPemain <= 2)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            actionText.GetComponent<Text>().text = "Ambil Pistol"; 
            ekstraCrossHair.SetActive(true);
         
        }

        if (Input.GetButtonDown("Action") && jarakDariPemain <= 2.5)
        {

            actionDisplay.SetActive(false);
            actionText.SetActive(false);
            markerTakeable.SetActive(false);
            pistolPalsu.SetActive(false);
            pistolAsli.SetActive(true); 
            ekstraCrossHair.SetActive(false);
            this.GetComponent<BoxCollider>().enabled = false;

        }
    }

    private void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
        ekstraCrossHair.SetActive(false);
    }
}
