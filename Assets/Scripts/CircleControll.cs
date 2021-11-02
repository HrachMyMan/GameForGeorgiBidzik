using UnityEngine;

public class CircleControll : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 6f);
    }
    void Update()
    {
        transform.Translate(speed * Vector2.left * Time.deltaTime);
    }
}
