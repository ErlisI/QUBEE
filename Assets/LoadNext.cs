using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{

  public void loadNextLvl() {

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

  }

}
