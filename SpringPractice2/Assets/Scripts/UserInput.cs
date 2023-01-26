using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class UserInput : MonoBehaviour
{
    public CharactersInterfaces characterObj;
    //public VehiclesInterfaces vehicleObj;
    private IMove moveObj;

    private void Awake()
    {
        moveObj = characterObj as IMove;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveObj.Move();
        }
    }
}
