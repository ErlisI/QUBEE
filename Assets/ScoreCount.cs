using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{

    public Transform player;
    public Text scoreT;

    void Update(){

        scoreT.text = player.position.z.ToString("0");

    }
}
