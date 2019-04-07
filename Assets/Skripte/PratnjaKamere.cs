using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PratnjaKamere : MonoBehaviour
{
    //za praćenje pozicije igraca
    public Transform target;
    //za smoothanje kamere
    public float smoothSpeed = 0.125f;
    //kako se kamera ne bi nalazila u igracu
    public Vector3 offset;
 
    //unutar metode zakljucavamo 
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
