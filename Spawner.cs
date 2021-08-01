using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoint;
    private float _flightTime = 0;
    private int _delayBetweenSpawns = 1;
    private int _timeUntilNextSpawn = 2;


    private void Update()
    {
        _flightTime += Time.deltaTime;
        if (_fligthTime - _delayBetweenSpawns > 0)
        {
            _delayBetweenSpawns = _delayBetweenSpawns + _timeUntilNextSpawn;
            Instantiate(_template, _spawnPoint.position, Quaternion.identity);
        }
    }
}
