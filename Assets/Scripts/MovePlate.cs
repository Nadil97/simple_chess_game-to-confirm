using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlate : MonoBehaviour
{
    public GameObject controller;

    GameObject reference = null;

    // Board positons
    int matrixX;
    int matrixY;

    //false: Movement,true:attacking
    public bool attack =false;

    public void Start()
    {
        if (attack)
        {
            //Change to red
            gameObject.GetComponent<SpriteRenderer>().color=new Color(1.0f, 0.0f, 0.0f,1.0f)
        }
    }

    public void OnMouseUp()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        if (attack)
        {
            GameObject cp = controller.GetComponent<Game>().GetPosition(matrixX, matrixY);
            Destroy(cp);
        }
        controller.GetComponent<Game>().SetPositionEmpty(reference.GetComponent<ChessMan>().GetXBoard(),
            reference.GetComponent<ChessMan>().GetYBord());
    }
}
