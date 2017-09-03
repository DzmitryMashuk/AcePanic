using UnityEngine;
using UnityEngine.SceneManagement;


public class StructurePlayer : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private SpriteRenderer playerSprite;
    private float speed = 1.8f;
    public static int poinsWithDed;
    private bool flipX;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speed *= -1;
            flipX = !flipX;
            playerSprite.flipX = flipX;
        }
        playerRb.velocity = new Vector2(speed, playerRb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            poinsWithDed = Points.points;
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            poinsWithDed = Points.points;
            SceneManager.LoadScene("GameOver");
        }
    }
}
