using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ball;
    public Vector3 spawnPosition;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(ball[0],spawnPosition,Quaternion.identity);
        }
        
    }
}
