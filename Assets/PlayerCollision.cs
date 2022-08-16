using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

  void OnCollisionEnter(Collision collInfo) {

    if(collInfo.collider.tag == "Obst"){
      GetComponent<PlayerMov>().enabled = false;
      FindObjectOfType<GameManager>().gameOver();
    }

  }

}
