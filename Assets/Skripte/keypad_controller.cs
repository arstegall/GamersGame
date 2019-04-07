using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad_controller : MonoBehaviour
{
    AudioSource press;       //zvukovna komponenta
    CodeLock codeLock;  //povezujemo sa drugom skriptom za provjeru i pokretanje otvaranja vrata

    public AudioClip press_sound;   //za uzet audio_clip

    int reachRange = 100;       //velicina zrake iz kamera za registraciju unosa

    private void Start()
    {
        press = GetComponent<AudioSource>();    //preuzimanje zvukovne komponente
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))        
        {
            CheckHitObj();      //ako je stisnuta lijeva tipka misa provjerava sto se stisnulo na ekranu(u sto udara ray)
        }
    }

    void CheckHitObj()
    {
        RaycastHit hit;     //sto udara kamera
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //zraka iz kamere se postavlja na poziciju misa

        if(Physics.Raycast(ray, out hit, reachRange))   //provjera "hit-a"
        {
            codeLock = hit.transform.gameObject.GetComponentInParent<CodeLock>();   //uzimamo objekt koji udari

            if(codeLock != null)    //ako udari
            {

                string value = hit.transform.name;  //value=ime objekta koje je udarilo(tipke odnosno brojke u nasem slucaju keypada)
                codeLock.SetValue(value);   //prosljeduje se vrijednost na sljedecu skritu
                //Debug.Log(value);     //cisto radi provjere u debugeru
                press.PlayOneShot(press_sound);   //pokretanje zvuka
            }
        }
    }
}
