using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHolder : MonoBehaviour
{

    [SerializeField]
    private int rows = 5;
    [SerializeField]
    private int cols = 5;
    [SerializeField]
    private float tileSize = 1.7f;
    [SerializeField]
    private float biasX = 0f;
    [SerializeField]
    private float biasY = 0f;

    private void Start()
    {
        GenerateGrid();
    }

    private void Update()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("GrassTile"));
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = col * tileSize - biasX ;
                float posY = row * -tileSize - biasY ;

                tile.transform.position = new Vector2(posX, posY);


            }
        }
        Destroy(referenceTile);
    }
}
