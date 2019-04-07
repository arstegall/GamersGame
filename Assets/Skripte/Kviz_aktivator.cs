using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kviz_aktivator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("table_kviz"))
        {
            SceneManager.LoadScene(2);
            Debug.Log("Ucitaj kviz");
        }
    }
}
