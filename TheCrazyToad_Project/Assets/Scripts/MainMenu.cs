using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
 public void PlayGame()
    {
        LoadNextLevel();
    }
  public  void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit(); 
    }
        void LoadNextLevel()
    {

      //  int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      //  int nextSceneIndex = currentSceneIndex + 1;
      //  if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
      //  {
      //      nextSceneIndex = 0;
      //  }
        SceneManager.LoadScene(1);
    }
}
