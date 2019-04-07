using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drugiUvod : MonoBehaviour
{

    public GameObject uvod;
    // Start is called before the first frame update
    void Start()
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
