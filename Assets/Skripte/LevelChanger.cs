using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    private int levelToLoad;
    
    // Update is called once per frame
   /* void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //pozivamo funkciju za sljedecu scenu(level)
            FadeToNextLevel();
        }
    }*/

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //postavljanje triggera da bi spojili animaciju:
    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;//sprema index levela u varijablu levelToLoad
        animator.SetTrigger("FadeOut");//pocinje fade
    }
    //da znamo kada je scena gotova i da se pokrene fade out:
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);//kada fade zavrsi poziva se nova scena
    }
}
