using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject squarePrefab;
    public int maxSquareCount;
    public float maxX;
    public float maxY;

    void Start()
    {
        var totalSquare = Random.Range(0,maxSquareCount);
        for (int i = 0; i < totalSquare; i++)
        {
            var xPosition = Random.Range(-maxX, maxX);
            var yPosition = Random.Range(-maxY, maxY);
            var pos = new Vector2(xPosition, yPosition);
            Instantiate(squarePrefab, pos, Quaternion.identity);
        }
    }
}
