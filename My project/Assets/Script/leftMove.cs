using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMove : MonoBehaviour
{
    public float leftMoveSpeed;
   
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
        if (other.gameObject.name == "Top Collider")
        {
            Destroy(gameObject);
          
        }
    }
}
