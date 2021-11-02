using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayerController : MonoBehaviour
{
    [SerializeField]
    public float speed;
    private Vector2 UpButtonPos;//Getting the position of the UpButton
    public GameObject UpButton;//reference to UpButton
    //Same thing with DownButton
    private Vector2 DownButtonPos;
    public GameObject DownButton;

    void Start()
    {
        UpButtonPos.y = UpButton.transform.position.y;
        DownButtonPos.y = DownButton.transform.position.y;
    }


    void Update()
    {
        if (UpButtonPos.y != UpButton.transform.position.y)
        {
            transform.Translate(speed * Vector2.up * Time.deltaTime);//Moving the object 
        }
        if(DownButtonPos.y != DownButton.transform.position.y)
        {
            transform.Translate(speed * Vector2.down * Time.deltaTime);//Moving the object 
        }
        if(transform.position.y <= -5f)
        {
            transform.position = new Vector3(transform.position.x, -4f, transform.position.z);
        }


    }
}
