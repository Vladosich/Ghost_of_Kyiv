using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private GameObject[] firePoints;

    public void SetCurrentNumberOfGuns()
    {
        if (firePoints[0].activeSelf == true && firePoints[1].activeSelf == false)
        {
            firePoints[0].SetActive(false);
            for (int i = 1; i < firePoints.Length; i++)
            {
                firePoints[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < firePoints.Length; i++)
            {
                firePoints[i].SetActive(true);
            }
        }
    }
}
