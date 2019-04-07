using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kodov_rotacija : MonoBehaviour
{
    //sve osi i public da se moze kroz sucelje unitya namjestat
    public int RotateByX;       //rotacija po x osi
    public int RotateByY;       //po y osi
    public int RotateByZ;       //po z osi

    void Update()
    {
        transform.Rotate(RotateByX * Time.deltaTime, RotateByY * Time.deltaTime, RotateByZ * Time.deltaTime);   //primjena rotacija na komponentu zeljenog objekta
    }
}
