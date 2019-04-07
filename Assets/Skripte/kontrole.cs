using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kontrole : MonoBehaviour
{
    public float speed = 11f;   //brzina naseg lika
    public Text score;      //ta prikaz rezultata

    public AudioSource zvuk;    //za zvuk
    public AudioClip collected; //zvuk za skupljen kod

    int djelovi_koda_za_otvorit_vrata;
    bool door_open_by_collecting = false;   //kad se sakupi dovoljan broj djelova vrata se otvaraju

    int dijelovi_counter = 0;

    Animator anim_door;  //za otvorit vrata
    GameObject vrata_kod;   //traena vrata
    

   void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;     //ako zelimo maknut pokazivac
        vrata_kod = GameObject.FindGameObjectWithTag("vrata_kod");  //pronalazak nasih vrata
        anim_door = vrata_kod.GetComponent<Animator>();     //potreban animator
        score.text = "Sakupljeno kodova: " + dijelovi_counter.ToString();
        zvuk = GetComponent<AudioSource>();

    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime; //kretnje misa
        float straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(straffe, 0, translation);   //iskoristavanje kretnji misa

        /*
         * //u slucaju da sakrijemo pokazivac(necemo jer nam treba za kasnije)
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        */
        if (dijelovi_counter >= 7)
        {
            door_open_by_collecting = true;
            anim_door.SetBool("Open_door_by_code", door_open_by_collecting);        //animatoru se prosljeduje var za pokretanje animacije
        }
    }

    private void OnTriggerEnter(Collider other)     //kada dotaknemo djelove koda za otvorit vrata
    {
        if (other.gameObject.CompareTag("kod_za_skupit"))
        {
            zvuk.PlayOneShot(collected);    //pokreni zvuk
            other.gameObject.SetActive(false);  //sakrivamo sakupljeno
            Debug.Log("Sakupljeno");        //za provjeru
            Debug.Log(other.gameObject);    //provjera
            dijelovi_counter++;
            score.text = "Sakupljeno kodova: " + dijelovi_counter.ToString() + " / 7";
        }
    }
}
