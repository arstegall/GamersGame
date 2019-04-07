using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kviz : MonoBehaviour
{
    public GameObject TextBox;      //"glavni" tekst

    //svi odgovori
    public GameObject odg1;
    public GameObject odg2;
    public GameObject odg3;
    public GameObject odg4;
    public GameObject odg5;
    public GameObject odg6;
    public GameObject odg7;
    public GameObject odg8;
    public GameObject odg9;

    //kraj kviza
    public GameObject finish_screen;
    public GameObject next;
    
    //zvukovi
    public AudioClip correct;
    public AudioClip wrong;
    public AudioSource zvuk;


    private void Start()
    {
        //postavljanje odgovora i pitanja
        finish_screen.SetActive(false);     //zavrsni ekran iskljucen
        //svi odgovori iskljuceni osim potrebnih
        next.SetActive(false);
        odg1.SetActive(true);
        odg2.SetActive(true);
        odg3.SetActive(true);
        odg4.SetActive(false);
        odg5.SetActive(false);
        odg6.SetActive(false);
        odg7.SetActive(false);
        odg8.SetActive(false);
        odg9.SetActive(false);
        TextBox.GetComponent<Text>().text = "Postupak kojim se optimizira rekurzivan postupak izracuna Fibonaccijevih brojeva naziva se:";
        odg1.GetComponentInChildren<Text>().text = "Rekurzivno planiranje";
        odg2.GetComponentInChildren<Text>().text = "Dinamicko planiranje";
        odg3.GetComponentInChildren<Text>().text = "Dinamicko programiranje";
        zvuk = GetComponent<AudioSource>();
    }


    public void Dinamicko_prog()    //u slucaju odgovra din. programiranje
    {
        zvuk.PlayOneShot(correct);
        TextBox.GetComponent<Text>().text = "Brisanje elemenata se kod strukture podataka red dogada na poziciji: ";
        odg1.SetActive(false);
        odg2.SetActive(false);
        odg3.SetActive(false);
        odg4.SetActive(true);
        odg5.SetActive(true);
        odg6.SetActive(true);
        odg4.GetComponentInChildren<Text>().text = "repa";
        odg5.GetComponentInChildren<Text>().text = "glave";
        odg6.GetComponentInChildren<Text>().text = "vrha";
    }

    public void glava_red() //u slucaju odgovora glava
    {
        zvuk.PlayOneShot(correct);
        odg4.SetActive(false);
        odg5.SetActive(false);
        odg6.SetActive(false);
        odg7.SetActive(true);
        odg8.SetActive(true);
        odg9.SetActive(true);
        TextBox.GetComponent<Text>().text = "Kakav ispis daje poziv funkcije f1(20); gdje je f1 definiran kao:\nvoidf1(int n){\nif(n>100)return;\ncout<<\" \"<<n;\nf1(2*n);\ncout<<\" \"<<n;\n}";
        odg7.GetComponentInChildren<Text>().text = "20 40 80 80 40 20";
        odg8.GetComponentInChildren<Text>().text = "20 40 80 40 20";
        odg9.GetComponentInChildren<Text>().text = "80 60 40 20";
    }

    public void finish()    //ako je tocan zadnji odgovor
    {
        zvuk.PlayOneShot(correct);
        TextBox.SetActive(false);
        odg1.SetActive(false);
        odg2.SetActive(false);
        odg3.SetActive(false);
        odg4.SetActive(false);
        odg5.SetActive(false);
        odg6.SetActive(false);
        odg7.SetActive(false);
        odg8.SetActive(false);
        odg9.SetActive(false);
        finish_screen.SetActive(true);
        next.SetActive(true);
        Debug.Log("Kraj kviza");
    }

    public void nextLevel()     //za prebacit se na sljedeci level
    {
        Debug.Log("NextLevel");
        SceneManager.LoadScene(5);
    }

    public void krivo()     //za krive odgovore
    {
        zvuk.PlayOneShot(wrong);
        Start();
    }

}
