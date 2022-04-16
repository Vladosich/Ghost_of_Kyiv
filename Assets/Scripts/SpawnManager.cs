using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject bomberPrefab;
    [SerializeField] private GameObject upgradePrefab;

    private int enemyDestroyCounter = 0;

    private readonly Vector2[] bomberSpawnPosition = new Vector2[3] {new Vector2(-2.2f,5.6f),
                                                            new Vector2(0,5.6f),
                                                            new Vector2(2.2f,5.6f)};

    public int EnemyDestroyCounter { get { return enemyDestroyCounter; } set { enemyDestroyCounter = value; } }

    private void Start()
    {
        SpawnBomber();
    }

    private void SpawnBomber()
    {
        for (int i = 0; i < bomberSpawnPosition.Length; i++)
        {
            Instantiate(bomberPrefab, bomberSpawnPosition[i], transform.rotation);
        }
    }

    public void SpawnUpgrade(Vector2 enemyDesroyPosition)
    {
        Instantiate(upgradePrefab, enemyDesroyPosition, transform.rotation);
    }
}
