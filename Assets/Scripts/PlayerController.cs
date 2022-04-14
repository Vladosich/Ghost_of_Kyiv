using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()
    {
        Vector2 cursorScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(cursorScreenPoint);
    }

    void OnMouseDrag()
    {
        Vector2 newPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }
}
