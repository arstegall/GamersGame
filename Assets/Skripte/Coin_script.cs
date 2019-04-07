using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_script : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            //za ispis bodova/score
            other.GetComponent<NewBehaviourScript>().points++;
            Destroy(gameObject); //unistava coin
        }
        
    }
    
}
