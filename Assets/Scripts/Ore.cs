using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    public readonly Material M_Iron;
    [SerializeField] private readonly Material M_Gold;
    [SerializeField] private readonly Material M_Diamond;
    [SerializeField] private readonly Material M_ROCK;
    [SerializeField] private readonly Material M_COPPER;

    private readonly static string[] _namesOre = { "IRON", "GOLD", "DIAMOND", "ROCK", "COPPER" };
    private int _numberForNamesOre;

    public string Name = _name;
    public int Count = _count;

    private static string _name;
    private static int _count;
    private float _speedMove = 2f;

    private Material _currentMaterial;
    private void Ininitialize(string name)
    {
        _name = name;

        switch (name.ToUpper())
        {
            case "IRON":
                _count = 1;
                _currentMaterial = M_Iron;
                gameObject.GetComponent<MeshRenderer>().material = _currentMaterial;
                break;
            case "GOLD":
                _count = 2;
                _currentMaterial = M_Gold;
                gameObject.GetComponent<MeshRenderer>().material = _currentMaterial;
                break;
            case "DIAMOND":
                _count = 3;
                _currentMaterial = M_Diamond;
                gameObject.GetComponent<MeshRenderer>().material = _currentMaterial;
                break;
            case "ROCK":
                _count = 4;
                _currentMaterial = M_ROCK;
                gameObject.GetComponent<MeshRenderer>().material = _currentMaterial;
                break;
            case "COPPER":
                _count = 5;
                _currentMaterial = M_COPPER;
                gameObject.GetComponent<MeshRenderer>().material = _currentMaterial;
                break;
        }

    }

    private void Start()
    {
        _numberForNamesOre = Random.Range(0, _namesOre.Length);
        Ininitialize(_namesOre[_numberForNamesOre]);

    }
    private void Update()
    {
        LinearMove(Vector3.left);
    }

    private void LinearMove(Vector3 direction)
    {
        transform.Translate(direction * _speedMove * Time.deltaTime);
    }
}
