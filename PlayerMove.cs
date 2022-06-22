

using UnityEngine;


//public class PlayerMove : MonoBehaviour
//{
//    public Rigidbody rb;
//    float dirX;
//    public float DirY = 500f;
//    public float moveSpeed = 30f;

//    public float Forwardforce = 2000f;

//    private void Start()
//    {
//        rb = GetComponent<Rigidbody>();
//    }

//    private void Update()
//    {
//        dirX = Input.acceleration.x * moveSpeed;
//        //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -16f, 16f), transform.position.y);
//        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -16f, 16f), transform.position.y);
//        transform.Rotate(new Vector3(Time.deltaTime * 50, 0, 0));
//    }

//    private void FixedUpdate()
//    {
//        rb.velocity = new Vector2(dirX, 0f);

//        if (rb.position.y < -1f)
//        {
//            FindObjectOfType<GameManager>().EndGame();
//        }
//    }
//}

public class PlayerMove : MonoBehaviour
{
    public float Forwardforce = 2000f;

    public Rigidbody rb;

    public float zSpeed = 14;
    public float yFallSpeed = 0.5f;
    public float xForceMultiplier = 14;

    private void FixedUpdate()
    {
        if (Input.acceleration.x > 0)
        {
            rb.velocity = new Vector3(Input.acceleration.x*xForceMultiplier, -yFallSpeed, zSpeed);
        }

        if (Input.acceleration.x < 0)
        {
            rb.velocity = new Vector3(Input.acceleration.x*xForceMultiplier, -yFallSpeed, zSpeed);
        }

        if (Input.acceleration.x  == 0)
        {
            rb.velocity = new Vector3(0, -yFallSpeed, zSpeed);
        }

        if (rb.position.y < -0.1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (rb.position.x < -20)
        {
            zSpeed = 4;
            xForceMultiplier = 4;
        }

        if (rb.position.x > 20)
        {
            zSpeed = 4;
            xForceMultiplier = 4;
        }

        if (rb.position.x > -20 && rb.position.x < 20)
        {
            zSpeed = 14;
            xForceMultiplier = 14;
        }
    }
}
