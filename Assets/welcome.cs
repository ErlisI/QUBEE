using UnityEngine;
using UnityEngine.SceneManagement;

public class welcome : MonoBehaviour
{

    public void start(){

      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
