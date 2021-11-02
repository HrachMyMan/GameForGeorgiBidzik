using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class UpButton : MonoBehaviour , IPointerDownHandler ,  IPointerUpHandler
{
    //Moving the button Down 
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 6f);
    }

    //Moving the button Up 
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 6f);

    }
}
