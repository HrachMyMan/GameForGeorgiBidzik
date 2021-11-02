using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirlceControll2 : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 6f);
    }
    void Update()
    {
        transform.Translate(speed * Vector2.right * Time.deltaTime);
    }
}
