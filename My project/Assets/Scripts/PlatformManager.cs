using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public float platformLength = 20.0f;
    public float timeToSpawnNewPlatform = 10.0f;

    private float lastPlatformSpawnTime;
    private Vector3 lastPlatformPosition;

    void Start()
    {
        lastPlatformSpawnTime = Time.time;
        SpawnPlatform(Vector3.zero); 
    }

    void Update()
    {
        if (Time.time - lastPlatformSpawnTime >= timeToSpawnNewPlatform)
        {
            SpawnPlatform(lastPlatformPosition + Vector3.right * platformLength);
            lastPlatformSpawnTime = Time.time;
        }
    }

    void SpawnPlatform(Vector3 position)
    {
        GameObject newPlatform = Instantiate(platformPrefab, position, Quaternion.identity);

        lastPlatformPosition = position + Vector3.right * (platformLength / 2);
    }
}