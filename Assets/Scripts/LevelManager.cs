using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    void Start()
    {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter); 
    }

    public void LoadLevel(string _name)
    {
        Debug.Log("Load level");
        SceneManager.LoadScene(_name);

    }

    public void QuitRequest()
    {
        Debug.Log("Quiting");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }  
 
}
