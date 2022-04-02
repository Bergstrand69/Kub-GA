using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamraMoment : MonoBehaviour
{
    public Camera kamra;
    float vertical;
    float horizontal;
    float kamraSpeed = 2;
    float momvmentSpeed;

    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    Vector3 momentvector()
    {
        float forwardInput = Input.GetKey(KeyCode.W) ? 1 : 0;
        float backwardInput = Input.GetKey(KeyCode.S) ? -1 : 0;
        float righwardInput = Input.GetKey(KeyCode.D) ? 1 : 0;
        float leftwardInput = Input.GetKey(KeyCode.A) ? -1 : 0;
        float upwardInput = Input.GetKey(KeyCode.Space) ? 1 : 0;
        float downwardInput = Input.GetKey(KeyCode.LeftControl) ? -1 : 0;
        return (transform.forward*forwardInput + transform.forward*backwardInput + transform.right*righwardInput + transform.right*leftwardInput + Vector3.up.normalized*upwardInput + Vector3.up.normalized*downwardInput).normalized*momvmentSpeed;


    }



    // Update is called once per frame
    void Update()
    {
        if(UIManager.MenyIsToggled)
        {
            Cursor.visible = true;
            return;
        }
        else
        {
            Cursor.visible = false;
        }

        vertical -= kamraSpeed*Input.GetAxisRaw("Mouse Y");
        horizontal += kamraSpeed*Input.GetAxisRaw("Mouse X");
        kamra.transform.eulerAngles = new Vector3(vertical,horizontal,0); 
        momvmentSpeed = Input.GetKey(KeyCode.LeftShift) ? 20 : 5;
        kamra.transform.position += momentvector()*Time.deltaTime;
        
    }
}
