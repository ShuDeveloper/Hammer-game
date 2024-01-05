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
        InvokeRepeating("TimeUpdate", 10, 1);
    }
        
    IEnumerator Spawn(GameObject[] inObject,Vector3 inPositions)
    { 
        while (true) 
        {
            float MinTime = MinSpawnTime;
            float MaxTime = MaxSpawnTime;
            //Random Variable
            float RandomTime =Random.Range(MinTime, MaxTime);          
            int RandomIndex = Random.Range(0, inObject.Length);
            
            yield return new WaitForSeconds(RandomTime);          
            GameObject NewObject= Instantiate(inObject[RandomIndex], inPositions, Quaternion.identity);

            //Change spawn object Speed
            leftMove Lmove = NewObject.GetComponent<leftMove>();
            Lmove.SpeedUpate(Speed);
        }
        
    }
    void TimeUpdate()
    {
        if(MaxSpawnTime>0.5f)
        {
          MaxSpawnTime -= 0.001f;
            Speed += 0.1f;
        }
    }
}
  