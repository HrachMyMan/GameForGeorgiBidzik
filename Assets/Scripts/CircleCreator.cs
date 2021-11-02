using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCreator : MonoBehaviour
{
    
    private float nextSpawn = 0.5f;
    public Transform circle;
    
    void Update()
    {
        nextSpawn -= Time.deltaTime;
        if(nextSpawn <= 0)
        {

            nextSpawn = 0.5f;
            Instantiate(circle, new Vector2(transform.position.x, Random.Range(-1.5f, 4.5f)), Quaternion.identity);
        }
    }
}
