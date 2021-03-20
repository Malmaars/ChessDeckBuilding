using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardAndPieces : MonoBehaviour
{
    Piece[,] ChessBoard = new Piece[8, 8];
    public GameObject whiteTile;
    public GameObject blackTile;
    // Start is called before the first frame update
    void Start()
    {
        //Mathf.Floor geeft de int onder de float
        //Math.Ceil geeft de int boven de float
        Debug.Log(Mathf.Ceil(0.5f));
        Debug.Log(Mathf.Floor(1f));
        for(int i = 0; i < 64; i++)
        {
            int divisionFactor = Convert.ToInt32(Mathf.Ceil(i / 8));
            float spawnX = (i - (8 * divisionFactor)) - 3.5f;
            float spawnY = divisionFactor - 3.5f;

            if((i + divisionFactor) % 2 == 0)
            {
                //spawn white tile
                Instantiate(whiteTile, new Vector2(spawnX, spawnY), new Quaternion(0,0,0,0));
            }

            else
            {
                //spawn black tile
                Instantiate(blackTile, new Vector2(spawnX, spawnY), new Quaternion(0, 0, 0, 0));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
