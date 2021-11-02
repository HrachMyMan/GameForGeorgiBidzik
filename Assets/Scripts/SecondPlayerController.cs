using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{
    public GameObject UpButton;
    private Vector2 UpButtonPos;
    public GameObject DownButton;
    private Vector2 DownButtonPos;
    [SerializeField]
    public float speed;

    private void Start()
    {
        UpButtonPos.y = UpButton.transform.position.y;
        DownButtonPos.y = DownButton.transform.position.y;

    }
    private void Update()
    {
        if(UpButtonPos.y != UpButton.transform.position.y)
        {
            transform.Translate(speed * Vector2.up * Time.deltaTime);
        }

        if (DownButtonPos.y != DownButton.transform.position.y)
        {
            transform.Translate(speed * Vector2.down * Time.deltaTime);
        }

        if (transform.position.y <= -5f)
        {
            transform.position = new Vector3(transform.position.x, -4f, transform.position.z);
        }
    }

}
