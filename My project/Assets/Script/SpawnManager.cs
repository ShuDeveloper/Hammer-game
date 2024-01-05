using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] PrefabsObject;
    public Vector3 spawnPosition;
    public float MinSpawnTime;
    public float MaxSpawnTime;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn(PrefabsObject,spawnPosition));
    }
        
    IEnumerator Spawn(GameObject[] inObject,Vector3 inPositions)
    { 
        while (true) 
        {
            float MinTime = MinSpawnTime;
            float MaxTime = MaxSpawnTime;
            int RandomIndex = Random.Range(0, inObject.Length);
            float RandomTime =Random.Range(MinTime, MaxTime);
            Debug.Log("time =" + RandomTime);
            yield return new WaitForSeconds(RandomTime); 
            Instantiate(inObject[RandomIndex], inPositions, Quaternion.identity);
        }
        
    }
}
