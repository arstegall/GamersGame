using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeLock : MonoBehaviour
{
    int codeLength;     //duljina koda
    int placeInCode = 0;    //koliko je uneseno znamenki
    bool open = false;  //za prosljedivanje u animator kontroler

    string attempedCode;       //za spremanje unesenih vrijednosti


    GameObject vrata;   //nalazimo vrata koja nam trebaju(radi animacije)
    Animator vrata_anim;    //animator nasih vrata
    AudioSource audio_status;  //komponenta za audio

    public AudioClip succes;
    public AudioClip fail;

    private void Start()
    {
        codeLength = 4;
        vrata = GameObject.FindGameObjectWithTag("vrata_bin");  //nalazimo vrata
        vrata_anim = vrata.GetComponent<Animator>();
        audio_status = GetComponent<AudioSource>();
    }

    public void SetValue(string value)
    {
        placeInCode++;  //registriran unos

        if(placeInCode <= codeLength)
        {
            attempedCode += value;      //unos dodajemo pokusaju
        }

        if(placeInCode == codeLength)
        {
            CheckCode();        //provjera pokusaja

            attempedCode = "";  //ako je krivo vracamo na poctak
            placeInCode = 0;
        }
    }

    void CheckCode()
    {
        if (attempedCode == "5497")
        {
            open = true;
            vrata_anim.SetBool("IsOpening", open);      //pokretanje animacije iz animator kontrolera
            audio_status.PlayOneShot(succes);       //play succes zvuka
        }
        else
        {
            audio_status.PlayOneShot(fail);     //play fail zvuka
            Debug.Log("Pokusaj: " + attempedCode);      //cisto za provjeru u debugeru
            Debug.Log("Krivi kod");
            
        }
    }

}
