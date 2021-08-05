using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawner : MonoBehaviour
{
    [SerializeField] GameObject ammo, spawnLocation1, spawnLocation2, spawnLocation3;
    GameObject[] spawnLocations;
    float ammoLimit = 2;


    private void Awake()
    {
        spawnLocations = new GameObject[3];
        spawnLocations[0] = spawnLocation1;
        spawnLocations[1] = spawnLocation2;
        spawnLocations[2] = spawnLocation3;

        StartCoroutine(SpawnAmmo());
    }


    IEnumerator SpawnAmmo()
    {
        if (ammoLimit > 0)
        {
            int spawnNumber = Random.Range(0, 2);

            GameObject.Instantiate<GameObject>(ammo,spawnLocations[spawnNumber].transform);
            ammoLimit--;

        }
        yield return new WaitForSeconds(10);
        StartCoroutine(SpawnAmmo());
    }

}
