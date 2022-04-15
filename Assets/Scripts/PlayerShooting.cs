using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    private readonly float shootRate = 0.2f;
    private readonly float firstShootDelay = 1f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnBullet), firstShootDelay, shootRate);
    }

    private void SpawnBullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
