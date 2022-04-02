using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ResetCubeToNormal : MonoBehaviour
{   
    public Text dragText; 
    public static List<Vector3> startingPos = new List<Vector3>();
    public static List<Quaternion> startingRotation = new List<Quaternion>();
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i<CheckForCubeSolve.allaBitar.Count; i++)
        {
               startingPos.Add(CheckForCubeSolve.allaBitar[i].transform.position);
        }
            
        
        
    }

    public void resetCube()
    {
        for(int i = 0; i<CheckForCubeSolve.allaBitar.Count; i++)
        {
            CheckForCubeSolve.allaBitar[i].transform.position = startingPos[i];
            CheckForCubeSolve.allaBitar[i].transform.rotation = Quaternion.Euler(0,0,0);
        }
        CubeRotationScript.antalDrag = 0;
        CubeRotationScript.counter = 0;
        CubeRotationScript.haveTurnedOnes = false;
        dragText.text = "Antal drag: 0";
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
