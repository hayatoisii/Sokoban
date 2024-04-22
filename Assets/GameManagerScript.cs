using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public GameObject playerPrefab;
    int[,] map;
    GameObject[,] field;


    // Start is called before the first frame update
    void Start()
    {
        /*/
        GameObject instance = Instantiate(
            playerPrefab,
            new Vector3(0, 0, 0),
            Quaternion.identity
            );
        /*/

        map = new int[,]
        {
            {0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 1 },
            {0, 0, 0, 0, 0 },
        };

        field = new GameObject
        [ 
            map.GetLength(0),
            map.GetLength(1)
        ];
       // string debugText = "";


        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
               if (map[y, x] == 1)
                {
                    field[y, x] = Instantiate(

                        playerPrefab,
                        new Vector3(x, map.GetLength(0) - 1 - y, 0),
                        Quaternion.identity

                        );
                }
                else
                {
                        field[y, x] = Instantiate(
                        playerPrefab,
                        new Vector3(x, map.GetLength(1) - 1 - y, 0),
                        Quaternion.identity
                        );
                }
            }
        }

      //  Debug.Log(debugText);


        /*/
        // Debug.Log("Hello world");
        map = new int[] { 0, 0, 0, 1, 0, 2, 0, 0, 2, 0, 0, 2, 0, 0 };
        PrintArray();
        /*/
    }


    // Update is called once per frame
    void Update()
    {


        /*/1
        int PlayerIndex = -1;
        string debugText = "";

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    PlayerIndex = i;
                    break;
                }
            }
                                   //‚±‚±plus‚¾‚ÆƒGƒ‰
            if (PlayerIndex < map.Length - 1)
            {
                map[PlayerIndex + 1] = 1;
                map[PlayerIndex] = 0;
            }


            for(int i = 0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ", ";
            }
            Debug.Log(debugText);

        }
        /*/


        /*/
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
          
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    PlayerIndex = i;
                    break;
                }
            }

            if (PlayerIndex < map.Length + 1)
            {
                map[PlayerIndex - 1] = 1;
                map[PlayerIndex] = 0;
            }


            for (int i = 0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ", ";
            }
            Debug.Log(debugText);

        }
        1/*/

        /*/
           if (Input.GetKeyDown(KeyCode.LeftArrow))
           {

               int PlayerIndex = GetPlayerIndex();

               MoveNumber(1, PlayerIndex, PlayerIndex - 1);
               PrintArray();
           }

           if (Input.GetKeyDown(KeyCode.RightArrow))
           {
               int PlayerIndex = GetPlayerIndex();

               MoveNumber(1, PlayerIndex, PlayerIndex + 1);
               PrintArray();
           }
           /*/

    }

    private Vector2Int GetPlayerIndex()
    {
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                if (field[y, x] == null) { continue; }
                {
                    return new Vector2Int(x, y);
                }
            }
        }
        return new Vector2Int(-1, -1);
    }

    //‚»‚Æ
    /*/
       void PrintArray()
       {
           string debugText = "";
           for (int i = 0; i < map.Length; i++)
           {
               debugText += map[i].ToString() + ", ";
           }
           Debug.Log(debugText);
       }

       int GetPlayerIndex()
       {
           for(int i = 0; i < map.Length; i++)
           {
               if (map[i] == 1)
               {
                   return i;
               }
           }
           return -1;
       }


       bool MoveNumber(int number, int moveFrom, int moveTo)
       {
           if (moveTo < 0 || moveTo >= map.Length) { return false; }

           if (map[moveTo] == 2)
           {

               int velocity = moveTo - moveFrom;

               bool success = MoveNumber(2, moveTo, moveTo + velocity);

               if (!success) { return false; }
           }
           map[moveTo] = number;
           map[moveFrom] = 0;
           return true;
       }
   /*/
}

/*/
bool MoveNumber(int number, int moveFrom, int moveTo)
{
    if (moveTo < 0 || moveTo >= moveTo.Length) { return false; }

    if (map[moveTo] == 2)
    {
        int velocity = moveTo - moveFrom;
        bool success = MoveNumber
            (2, moveTo, moveTo + velocity);
    }

    map[moveTo] = number;
    map[moveFrom] = 0;
    return true;
}
/*/
