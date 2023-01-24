using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Game : MonoBehaviour
{

    public GameObject ChessPease;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ChessPease, new Vector3(0, 0, -1), Quaternion.identity);
        
    }

    
}
