using UnityEngine;

public class Spike : MonoBehaviour
{
    private Rigidbody2D spikeRb;
    private int speedFall = 0;
    private float posX, posY;
    private Vector3 position;
    public GameObject spikePrefab;


    void Start()
    {
        spikeRb = GetComponent<Rigidbody2D>();
        speedFall = Random.Range(1, 6);
        spikeRb.drag = speedFall;
        position = transform.position;
    }

    void OnBecameInvisible()
    {
        Instantiate(spikePrefab, position, transform.localRotation);
        Points.points++;
        Destroy(this.gameObject);
    }
}
