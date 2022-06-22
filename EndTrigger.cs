using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gamemanager;

    private void OnTriggerEnter(Collider other)
    {
        gamemanager.CompleteLevel();
    }
}


//credit: http://old.brackeys.com/preview/2d-platformer-course for end trigger
