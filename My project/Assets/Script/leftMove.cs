using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMove : MonoBehaviour
{
    public float leftMoveSpeed;
     ParticleSystem explosionFX;
     AudioSource audioSoure;
    public AudioClip clip;
        private void Awake()
    {
        audioSoure = GetComponent<AudioSource>();
        explosionFX= GetComponentInChildren<ParticleSystem>();
        explosionFX.Stop();
     
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * leftMoveSpeed*Time.deltaTime);
        print("time speed "+ leftMoveSpeed);
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
            Destroy(gameObject, 0.15f);
            audioSoure.PlayOneShot(clip, 1f);
        }
        if (other.gameObject.name == "Top Collider" && gameObject.tag == "Box")
        {
            Time.timeScale = 0f;
            print("Game Over");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.contacts[0].otherCollider.transform.gameObject.name == "Bottom Collider" && gameObject.tag == "Box")
        {
            Time.timeScale = 0f;
            print("Game Over");
        }

        //if (collision.contacts[0].otherCollider.transform.gameObject.name == "Top Collider" && gameObject.tag == "Box")
        //{
        //    Time.timeScale = 0f;
        //    print("Game Over");
        //}

    }

}

