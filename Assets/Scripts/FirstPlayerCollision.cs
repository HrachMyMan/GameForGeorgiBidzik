using UnityEngine;

public class FirstPlayerCollision : MonoBehaviour
{
    public Transform spawn;
    private ScoreManager _ScoreManager;

    private void Start()
    {
        _ScoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "circle")
        {
            transform.position = spawn.position;
        }
        if(col.tag == "Finish")
        {
            transform.position = spawn.position;
            _ScoreManager.FirstPlayerScore += 1;
        }
    }

}
