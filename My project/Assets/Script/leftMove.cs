
using UnityEngine;

public class leftMove : MonoBehaviour
{
    public float leftMoveSpeed;
    public AudioClip clip;
    ParticleSystem explosionFX;
    AudioSource audioSoure;
    GameManager gameManager;
    int ball=1;

    private void Awake()
    {
        audioSoure = GetComponent<AudioSource>();
        explosionFX = GetComponentInChildren<ParticleSystem>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        explosionFX.Stop();
    }   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * leftMoveSpeed * Time.deltaTime);
        //print("time speed " + leftMoveSpeed);
        if (transform.position.x < -13)
        {
            Destroy(gameObject);
        }
    }
    public void SpeedUpate(float speed)
    {
        leftMoveSpeed = speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Top Collider" && gameObject.tag == "Ball")
        {
            explosionFX.Play();
            gameManager.BallCount(ball);
            Destroy(gameObject, 0.15f);
            audioSoure.PlayOneShot(clip, 1f);
        }       
    }
   

}

