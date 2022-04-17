using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    [SerializeField] private SimpleTouchPad touchPad;

    private void FixedUpdate()
    {
        transform.position += new Vector3(touchPad.direction.x,touchPad.direction.y)/5;
    }
}
