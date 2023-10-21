using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private const float PlayerY = 0f;

    void Start()
    {
        PrintInstructions();
    } 
    void Update()
    { 
        MovePlayer();
    }

    private void MovePlayer()
    {
        var xValue = Input.GetAxis("Horizontal");
        var zValue = Input.GetAxis("Vertical");
        var moveMargin = new Vector3(xValue,PlayerY,zValue) * (moveSpeed*Time.deltaTime);
        
        transform.Translate(moveMargin);
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome To the game");
        print("Move your player with WASD or arrow keys");
        print("Don't hit the Walls!");
    }
}
