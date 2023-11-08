using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform platform;
    public float spawnInterval = 3.0f;
    public float spawnOffset = 5.0f;
    public float spawnDistance = 20.0f;

    private float lastSpawnTime;
    private Vector3 initialSpawnPosition;

    void Start()
    {
        lastSpawnTime = Time.time;
        initialSpawnPosition = new Vector3((platform.position.x-50), (platform.position.y+0.5f), platform.position.z);
    }

    void Update()
    {
        spawnOffset = (spawnOffset + (0.1f * Time.deltaTime));

        if (Time.time - lastSpawnTime >= (spawnInterval-(1f*Time.deltaTime)))
        {
            SpawnEnemy();
            lastSpawnTime = Time.time;
        }
    }

    void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, enemyPrefabs.Length);
        GameObject enemyPrefab = enemyPrefabs[randomIndex];

        Vector3 spawnPosition = initialSpawnPosition + Vector3.right * (spawnDistance + spawnOffset);

        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        initialSpawnPosition = spawnPosition;
    }
}