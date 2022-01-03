using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore_Spawner : MonoBehaviour
{
    [SerializeField] private Ore _ore;
    private Ore _currentOre;

    private float _timeToSpawn = 5f;
    private void Start()
    {
        
    }

    private void Update()
    {
        _timeToSpawn -= Time.deltaTime;

        if (_timeToSpawn <= 0)
        {
            _currentOre = Instantiate(_ore, transform.position, Quaternion.identity);
            _timeToSpawn = 10f;
        }
    }
}
