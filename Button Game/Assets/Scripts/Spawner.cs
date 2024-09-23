using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawn Points\n")]
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

    [Header("Toy List\n")]
    public List<GameObject> toyList = new List<GameObject>();

    void Start()
    {
        StartCoroutine(SpawnToys());
    }

    IEnumerator SpawnToys()
    {
        yield return new WaitForSeconds(10f);

        int randomListObject1 = Random.Range(0, toyList.Count);
        int randomListObject2 = Random.Range(0, toyList.Count);
        int randomListObject3 = Random.Range(0, toyList.Count);
        Vector3 spawnPoint1Vector3 = spawnPoint1.transform.position;
        Vector3 spawnPoint2Vector3 = spawnPoint2.transform.position;
        Vector3 spawnPoint3Vector3 = spawnPoint3.transform.position;

        Instantiate(toyList[randomListObject1], spawnPoint1Vector3, Quaternion.identity);
        Instantiate(toyList[randomListObject2], spawnPoint2Vector3, Quaternion.identity);
        Instantiate(toyList[randomListObject3], spawnPoint3Vector3, Quaternion.identity);

        yield return StartCoroutine(SpawnToys());
    }
}
