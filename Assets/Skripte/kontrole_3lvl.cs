using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kontrole_3lvl : MonoBehaviour
{
    public float speed = 15f;   //brzina naseg lika

    Animator kretnje;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        kretnje = GetComponent<Animator>();

    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime; //kretnje misa
        float straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(straffe, 0, translation);   //iskoristavanje kretnji misa


        if(Input.GetAxis("Vertical")!=0 || Input.GetAxis("Horizontal") != 0)
        {
            kretnje.SetBool("isWalking", true);
        }
        else
        {
            kretnje.SetBool("isWalking", false);
        }
        
         //u slucaju da sakrijemo pokazivac(necemo jer nam treba za kasnije)
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "lift")
        {
            SceneManager.LoadScene(6);
        }
    }
}
