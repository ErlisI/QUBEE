using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    public Rigidbody rB;

    public float forwardForce = 2000f;
    public float sideForce = 500f;

    // use "FixedUpdate" for working with Physics
    void FixedUpdate(){

      //adds a force to the player
      rB.AddForce(0, 0, forwardForce * Time.deltaTime);

      if(Input.GetKey("d")){
        rB.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }

      if(Input.GetKey("a")){
        rB.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }

      if(rB.position.y < -1f){
        FindObjectOfType<GameManager>().gameOver();
      }

    }
}
