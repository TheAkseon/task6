using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoint;
    private float _time = 0;
    private int _nextSpawn;

    private void Start()
    {
        _nextSpawn = _nextSpawn + 1;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        if (_time - _nextSpawn > 0)
        {
            _nextSpawn = _nextSpawn + 2;
            Instantiate(_template, _spawnPoint.position, Quaternion.identity);
        }
    }
}
