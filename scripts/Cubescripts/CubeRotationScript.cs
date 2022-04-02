using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeRotationScript : MonoBehaviour
{

    CheckForCubeSolve CheckSolveScript;
    public GameObject GameManager;
    public GameObject moveContent;
    public InputField textRuta;
    public static List<Action> dragLista = new List<Action>();

    List<GameObject> allakubbitar;
    
    public static int counter = 0; //håller kol på vilket index som ska utföras i action listan
    public static int antalDrag; //totala antalet drag
    float updateTimer = 0;
    public static float timeForOneFrame = 0.5f;
    bool spaceIsNotPressed = true;
    public static bool haveTurnedOnes = false;
    int dragListansLängd;
    public static bool pouseWasPressed = false;

    Vector3 centerofcube;
   
    

    
    

    
    public Text AntalDragText;
    void roundTransform(GameObject x)
    {

        float exactPositionX = Mathf.Round(x.transform.position.x);
        float exactPositionY = Mathf.Round(x.transform.position.y);
        float exactPositionZ = Mathf.Round(x.transform.position.z);
        x.transform.position = new Vector3(exactPositionX,exactPositionY,exactPositionZ);
        float exactRotaionX = Mathf.Round(x.transform.rotation.eulerAngles.x);
        float exactRotaionY = Mathf.Round(x.transform.rotation.eulerAngles.y);
        float exactRotaionZ = Mathf.Round(x.transform.rotation.eulerAngles.z);
        x.transform.rotation = Quaternion.Euler(exactRotaionX,exactRotaionY,exactRotaionZ);  
    
    }

    public void AddU()
    {        
        dragLista.Add(U);     
        
    }
    public void AddU_()
    {        
        dragLista.Add(U_); 
           
    }

    public void AddR()
    {
        dragLista.Add(R);  
        
    }

    public void AddR_()
    {
        dragLista.Add(R_);  
        
    }

    public void AddL()
    {
        dragLista.Add(L);
        
    }

    public void AddL_()
    {
        dragLista.Add(L_);
        
    }

    public void AddF()
    {
        dragLista.Add(F);
        
    }

    public void AddF_()
    {
        dragLista.Add(F_);
        
    }

    public void AddM()
    {
        dragLista.Add(M);
        
    }

    public void AddM_()
    {
        dragLista.Add(M_);
        
    }

    public void AddS()
    {
        dragLista.Add(S);
         
    }

    public void AddS_()
    {
        dragLista.Add(S_);
         
    }

    public void AddD()
    {
        dragLista.Add(D);
         
    }

    public void AddD_()
    {
        dragLista.Add(D_);
        
    }

    public void AddX()
    {
        dragLista.Add(X);
         
    }

    public void AddX_()
    {
        dragLista.Add(X_);
         
    }
     
    public void AddB()
    {
        dragLista.Add(B);
         
    }

    public void AddB_()
    {
        dragLista.Add(B_);
        
    }

    public void AddE()
    {
        dragLista.Add(E);
    }

    public void AddE_()
    {
        dragLista.Add(E_);
    }



    
    
 

    public void U()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.y == 1)
            {         
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.up, 90);
            roundTransform(allakubbitar[i]);     
            }
        }
        
    }

    public void U_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.y == 1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.up, -90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void R()
    {   
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.x == 1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.right, 90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void R_()
    {
       for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.x == 1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.right, -90);
            roundTransform(allakubbitar[i]);
            }
        }
        
    }

    public void F()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.z == -1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.forward, -90);
            roundTransform(allakubbitar[i]);
            }
        }
    }
    public void F_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.z == -1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.forward, 90);
            roundTransform(allakubbitar[i]);
            }
        }
    }


    public void L()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.x == -1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.right, -90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void L_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.x == -1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.right, 90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void M()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.x == 0)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.right, -90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void M_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.x == 0)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.right, 90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void S()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.z == 0)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.forward, -90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void S_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.z == 0)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.forward, 90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    
    public void E()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.y == 0)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.up, -90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    
    public void E_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.y == 0)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.up, 90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void B()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.z == 1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.forward, 90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void B_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.z == 1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.forward, -90);
            roundTransform(allakubbitar[i]);
            }
        }
    }

    public void D()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.y == -1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.up, -90);
            roundTransform(allakubbitar[i]);
            }
        }
        
    }

    public void D_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            if(allakubbitar[i].transform.position.y == -1)
            {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.up, 90);
            roundTransform(allakubbitar[i]);
            }
        }
        
    }


    void X()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.right, 90);
            roundTransform(allakubbitar[i]);          
        }
        
    }

    void X_()
    {
        for(int i = 0; i<allakubbitar.Count; i++)
        {
            allakubbitar[i].transform.RotateAround(centerofcube, Vector3.right, -90);
            roundTransform(allakubbitar[i]);          
        }
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
        CheckSolveScript = GameObject.FindGameObjectWithTag("solve").GetComponent<CheckForCubeSolve>();
        allakubbitar = CheckForCubeSolve.allaBitar;
        centerofcube = CheckForCubeSolve.rotationPoint;
        



    }

    // Update is called once per frame
    void Update()
    {

        if(dragLista.Count == 0 || UIManager.MenyIsToggled)
        {
            return;
        }

     

        if(Input.GetKeyDown(KeyCode.F)) // för att kunna puasa
        {
            pouseWasPressed = pouseWasPressed ? false : true;
            
        }

        if(pouseWasPressed) // för att kunna puasa
        {
            
            return;
        }

        updateTimer += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.E) && CheckSolveScript.solved())
        {
            dragListansLängd = dragLista.Count;
            spaceIsNotPressed = false;
            antalDrag = 0;
        }

        if(counter == 0)
        {

            if(CheckSolveScript.solved() && haveTurnedOnes)
            {
                
            moveContent.GetComponent<PanelContentScript2>().newItem(antalDrag,dragLista.Count,textRuta.text);
            haveTurnedOnes = false;
            string[] content = {textRuta.text +" "+ dragLista.Count.ToString()  +" "+ (antalDrag/dragLista.Count).ToString() };
            Textwriter.writeToFile(content,"dragstatestik");
            
            
            }

        }
        

        if(updateTimer <= timeForOneFrame || CheckSolveScript.solved() && spaceIsNotPressed && counter == 0)
        {
            
            return;
            
        }

       

        dragLista[counter]();
        counter++;
        antalDrag++;
        AntalDragText.text = "Antal drag: "+ antalDrag.ToString();
        if(counter == dragLista.Count)
        {
            counter = 0;
        }
        updateTimer = 0;
        spaceIsNotPressed = true;
        haveTurnedOnes = true;
    }
}
