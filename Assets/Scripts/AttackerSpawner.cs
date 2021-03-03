using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackersPrefab;
    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn) 
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning() {
        spawn = false;
    }

    private void SpawnAttacker() 
    {
        var attackerIndex = Random.Range(0, attackersPrefab.Length);
        Spawn(attackersPrefab[attackerIndex]);
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(
                            myAttacker,
                            transform.position,
                            Quaternion.identity
                        ) as Attacker;
        newAttacker.transform.parent = transform;
    }
}
