using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Game : MonoBehaviour
{

    public GameObject ChessPease;
    // possion and each chesspiese
    private GameObject[,] position = new GameObject[8, 8];
    private GameObject[] playerBlack = new GameObject[16];
    private GameObject[] playerWhite = new GameObject[16];

    private string currentPlayer = "white";

    private bool gameOver =false;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ChessPease, new Vector3(0, 0, -1), Quaternion.identity);
        
    }

    
}
