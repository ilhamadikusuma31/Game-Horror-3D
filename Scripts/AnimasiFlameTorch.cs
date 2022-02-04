using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiFlameTorch : MonoBehaviour
{
    public int modeTorch;
    public GameObject flameLight;

    // Update is called once per frame
    void Update()
    {
        if (modeTorch == 0)
        {
            StartCoroutine(gantiMode());
        }
    }

    IEnumerator gantiMode()
    {
        modeTorch = Random.Range(1, 4);
        if (modeTorch ==1) {
            flameLight.GetComponent<Animation>().Play("TorchAnim1");
        }        
        if (modeTorch ==2) {
            flameLight.GetComponent<Animation>().Play("TorchAnim2");
        }
        if (modeTorch == 3)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim3");
        }

        yield return new WaitForSeconds(0.99f);
        modeTorch = 0;
    }


}
