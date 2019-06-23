
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
  public void GameOver(){
        
        SceneManager.LoadScene("Retry");
        
      }
}
