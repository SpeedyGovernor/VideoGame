using UnityEngine;



public class Collision : MonoBehaviour
{

    public PlayerMove stop;
   

    void OnCollisionEnter(UnityEngine.Collision collision_info)
    {
        if (collision_info.gameObject.tag == "Obstacles")
        {
            Debug.Log("Obstacle Detected");
            stop.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
