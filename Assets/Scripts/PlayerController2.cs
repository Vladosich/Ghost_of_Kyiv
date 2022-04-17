using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    [SerializeField] private GameObject character;

    private float planeSpeed = 500f;

    private void FixedUpdate()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,10));
            character.transform.Translate(Vector3.MoveTowards(character.transform.position, target, planeSpeed * Time.deltaTime) - character.transform.position);
        }
    }
}
