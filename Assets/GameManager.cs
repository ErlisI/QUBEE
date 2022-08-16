using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

  public bool gameEnded = false;
  public float restartDelay = 1f;

  public GameObject completeLvlUI;

  //A function which is called when the game is over based on our requirements
  public void gameOver() {

    if(gameEnded == false){

      gameEnded = true;
      Invoke("restartGame", restartDelay); //a small delay after the game is restared

    }
  }

  public void finishLine() {

    completeLvlUI.SetActive(true);

  }

  //Restarts the game
  void restartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

}