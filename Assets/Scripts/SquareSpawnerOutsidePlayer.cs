using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawnerOutsidePlayer : MonoBehaviour
{
    public GameObject squarePrefab;
    public Transform player;
    public int maxSquareCount;
    public float maxX;
    public float maxY;
    public float offset;

     void OnEnable()
    {
        ScoreManager.OnHitSquare += SpawnNewSquare;
    }   

    void OnDisable()
    {
        ScoreManager.OnHitSquare -= SpawnNewSquare;
    }

    void Start()
    {
        var totalSquare = Random.Range(0,maxSquareCount);
        for (int i = 0; i < totalSquare; i++)
        {
            SpawnNewSquare();
        }
    }

    void SpawnNewSquare()
    {
        Instantiate(squarePrefab, FindPositionOusidePlayer(player.position), Quaternion.identity);
    }

    Vector2 FindPositionOusidePlayer(Vector3 player)
    {
        Vector2 pos;
        bool inBoundX, inBoundY;
        do
        {
            var xPosition = Random.Range(-maxX, maxX);
            var yPosition = Random.Range(-maxY, maxY);
            pos = new Vector2(xPosition, yPosition);

            inBoundX =  pos.x >= -offset + player.x && pos.x <= offset + player.x;
            inBoundY =  pos.y >= -offset + player.y && pos.y <= offset + player.y;
        } 
        while (inBoundX && inBoundY);

        return pos;
    }
}
