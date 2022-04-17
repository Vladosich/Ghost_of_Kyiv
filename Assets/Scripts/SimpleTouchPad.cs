using UnityEngine;
using UnityEngine.EventSystems;

public class SimpleTouchPad : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    private Vector2 origin;
    public Vector2 direction;
    private void Awake()
    {
        origin = Vector2.zero;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        origin = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentPosition = eventData.position;
        Vector2 directionRaw = currentPosition - origin;
        direction = directionRaw.normalized;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        origin = Vector2.zero;
        direction = Vector2.zero;
    }

    public Vector2 GetDirection()
    {
        return direction;
    }


}

