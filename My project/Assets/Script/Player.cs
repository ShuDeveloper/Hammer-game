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
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = Quaternion.Euler(0, 0, -67.529f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            transform.rotation = Quaternion.Euler(transform.position.x, 0, 0);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            PlayerPostion = new Vector3(transform.position.x,3.4f,0);
            transform.position = PlayerPostion;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            PlayerPostion = new Vector3(transform.position.x, -4, 0);
            transform.position = PlayerPostion;
        }
        
    }
}
