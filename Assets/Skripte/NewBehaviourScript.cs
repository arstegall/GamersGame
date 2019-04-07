using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    //skupljanje novcica:
    public int points = 0;

    public int potrebno_novcica = 15;

    AudioSource hit_obstacle;
    public AudioClip hit;
    public Text score;

    private CharacterController controller;
    private Vector3 moveVector;
    public float speed = 10.0f;
    public float verticalVelocity = 0.0f;
    public float gravity = 12.0f;
    public GameObject p1;


    //private float animationDuration = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        hit_obstacle = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Time.time < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }*/
        moveVector = Vector3.zero;
        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        //X - Lijevo i desno
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        //Y - Dolje i gore
        moveVector.y = verticalVelocity;
        //Z - Naprijed i nazad
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);

        if (points == potrebno_novcica)
        {
            Debug.Log("Prebaci scenu");
            SceneManager.LoadScene(7);
        }

        score.text = "Score: " + points + " / " + potrebno_novcica.ToString();

    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        if (other.gameObject.CompareTag("test"))
        {
            p1.SetActive(true);
            Debug.Log("trigger activated");
        }
        if (other.gameObject.CompareTag("prepreka"))
        {
            hit_obstacle.PlayOneShot(hit);
            if (points > 0)
                points--;
        }


    }

    //funkcija za novcice:
    private void OnGUI()
    {
        //GUI.Label(new Rect(10, 10, 100, 20), "Score: " + points);
        

    }
    

}
