using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 PlayerPostion;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPostion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovement();
        if (transform.position.x < -12)
        {
            Destroy(gameObject);
            print("Game Over");
            Time.timeScale =0;
        }
    }

    void PlayerMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = Quaternion.Euler(0, 0, -67);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            PlayerPostion = new Vector3(-8.27f, 3.4f, transform.position.z);
            transform.position = PlayerPostion;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            PlayerPostion = new Vector3(-8.27f, -4, transform.position.z);
            transform.position = PlayerPostion;
        } 
    }
}
