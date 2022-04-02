using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UIManager : MonoBehaviour
{
    
    
    
    
    bool tabIsPressed;
    public CanvasGroup canvasGroupMeny;
    public CanvasGroup canvasGroupInGame;
    public CanvasGroup canvasCrosshair;
    static public bool crosshairIsToggled = true; 
    public static bool MenyIsToggled = false;
    public Text pouswaspressedtext;
    void HideMeny()
    {
    canvasGroupMeny.alpha = 0f;
    canvasGroupMeny.blocksRaycasts = false; 
    canvasGroupMeny.interactable = false;
    canvasGroupInGame.alpha = 1f;
    canvasGroupInGame.blocksRaycasts = true; 
    canvasGroupInGame.interactable = true;

   
    
    }

    void ShowMeny() 
    {
    canvasGroupMeny.alpha = 1f;
    canvasGroupMeny.blocksRaycasts = true;
    canvasGroupMeny.interactable = true;
    canvasGroupInGame.alpha = 0f;
    canvasGroupInGame.blocksRaycasts = false; 
    canvasGroupInGame.interactable = false;

   
    
    
    }

    public void returnToGame()
    {
        tabIsPressed = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        HideMeny();
        
        
    }

   





    // Update is called once per frame
    void Update()
    {

        if(CubeRotationScript.pouseWasPressed)
        {
            Color _color = pouswaspressedtext.color;
            _color.a = 1;
            pouswaspressedtext.color = _color;
        }
        else
        {
            Color _color = pouswaspressedtext.color;
            _color.a = 0f;
            pouswaspressedtext.color = _color;

        }

        if(Input.GetKeyDown(KeyCode.C) && !MenyIsToggled)
        {
            crosshairIsToggled = crosshairIsToggled ? false : true;
        }

        if(Input.GetKeyDown(KeyCode.Tab) || tabIsPressed)
        {
            MenyIsToggled = MenyIsToggled ? false : true;

            if(MenyIsToggled) 
            {
                ShowMeny();
            }
            else 
            {
                HideMeny();
            }
            tabIsPressed = false;
        }

        if(crosshairIsToggled && !MenyIsToggled)
        {
            canvasCrosshair.alpha = 1f;
            canvasCrosshair.blocksRaycasts = true;
            canvasCrosshair.interactable = true;
        }
        else 
        {
            canvasCrosshair.alpha = 0f;
            canvasCrosshair.blocksRaycasts = false;
            canvasCrosshair.interactable = false;
        }
         

        

        

    }
}
