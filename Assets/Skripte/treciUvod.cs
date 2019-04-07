using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treciUvod : MonoBehaviour
{
    public GameObject uvod;

    public float delay = 2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer(delay));
    }

    IEnumerator Timer(float delay)
    {
        yield return new WaitForSeconds(delay);
        pocetak();
    }


    void pocetak()
    {
        Time.timeScale = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            uvod.SetActive(false);
            Time.timeScale = 1f;
        }

    }
}
