using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.contacts[0].otherCollider.transform.gameObject.name == "Bottom Collider" )
        {
            Time.timeScale = 0f;
            print("Game Over");
        }

        if (collision.contacts[0].otherCollider.transform.gameObject.name == "Top Collider" )
        {
            Time.timeScale = 0f;
            print("Game Over");
        }

    }
}
