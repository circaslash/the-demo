using UnityEngine;

public class GroundTile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private GroundSpawner groundSpawner;

    [SerializeField] GameObject obstaclePrefab;

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();   
        SpawnObstacle(); 
    }

    private void OnTriggerExit(Collider other) {

        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);

    }

    void SpawnObstacle () {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
