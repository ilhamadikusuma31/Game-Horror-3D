using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PemainCastingRay : MonoBehaviour
{
    //var ini biar bisa dipanggil ke script lain
    public static float targetKeObjek;    

    //var biar keliatan aja di inspector, jarak antar playernya ke suatu objek
    public float keObjek;

    //var hit buat raycast
    RaycastHit hit;

    void Update()
    {
                            //posisi dari     , posisi ke(tapi harus hadap depan)            ,output hit dari kedua parameter sebelumnya
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            //assign di kedua var ini
            keObjek = hit.distance;
            targetKeObjek = keObjek;
        }
    }
}
