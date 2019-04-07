using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class poc_video : MonoBehaviour
{
    public float delay = 67;
    public float text = 15;
    public GameObject text_prikaz;

    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
        StartCoroutine(MakniText(text));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(1);
    }

    IEnumerator MakniText(float text)
    {
        yield return new WaitForSeconds(text);
        text_prikaz.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
}
