using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMove : MonoBehaviour
{
    [SerializeField] float leftMoveSpeed; //update this speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * leftMoveSpeed*Time.deltaTime);
        if (transform.position.x < -13)
        {
            Destroy(gameObject);
        }
    }
}
