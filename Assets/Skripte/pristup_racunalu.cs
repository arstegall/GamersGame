using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pristup_racunalu : MonoBehaviour
{

    public GameObject OpenText = null;

    bool access = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "racunalo")
        {
            OpenText.SetActive(true);
            access = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "racunalo")
        {
            OpenText.SetActive(false);
            access = false;
        }
    }

    private void Update()
    {
        if (access)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("zavrsne scena");
                SceneManager.LoadScene(3);

            }
        }
    }
}
