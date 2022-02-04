using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Opening : MonoBehaviour
{
    public GameObject pemain;
    public GameObject fadeScreenIn;
    public GameObject textBox;
    void Start()
    {
        pemain.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine("ScenePemain");
    }

    IEnumerator ScenePemain()
    {
        yield return new WaitForSeconds(1.5f);
        fadeScreenIn.SetActive(false);
        textBox.GetComponent<Text>().text = "Aku harus pergi dari sini";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "";
        pemain.GetComponent<FirstPersonController>().enabled = true;
    }
}
