using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunMovesscript : MonoBehaviour
{
    List<Action> allmoves = new List<Action>();
    List<Action> movesinaction = new List<Action>();
    public CubeRotationScript nodeofcube;
    public CheckForCubeSolve cubesolvecheck;
    
    int numberoftestnings;
    int counter;
    int repetitions = 0;
    int dragnumer = 0;

    bool Randommode = true;
    string nameoffile = "1000Urval";
    int numberofeachserie = 1000;
    int serienumber = 18;
    int maximalserienumber = 20;

    void Start()
    {
        dragnumer = 0;
        
        

        allmoves.Add(nodeofcube.U);
        allmoves.Add(nodeofcube.U_);
        allmoves.Add(nodeofcube.R);
        allmoves.Add(nodeofcube.R_);
        allmoves.Add(nodeofcube.L);
        allmoves.Add(nodeofcube.L_);
        allmoves.Add(nodeofcube.D);
        allmoves.Add(nodeofcube.D_);
        allmoves.Add(nodeofcube.B);
        allmoves.Add(nodeofcube.B_);
        allmoves.Add(nodeofcube.F);
        allmoves.Add(nodeofcube.F_);
        allmoves.Add(nodeofcube.S);
        allmoves.Add(nodeofcube.S_);
        allmoves.Add(nodeofcube.M);
        allmoves.Add(nodeofcube.M_);
        allmoves.Add(nodeofcube.E);
        allmoves.Add(nodeofcube.E_);

    if(Randommode)
    {
         AddmovesofactionRandomnew();
    }
    else
    {
        for(int i = 0; i <serienumber; i++)
        {
            movesinaction.Add(allmoves[0]);
        }        
    }

    for(int i=serienumber-1; i < maximalserienumber; i++)
    {
        Textwriter.create(nameoffile + (i+1).ToString());
        
    }
        
        
    }

    
    void Update()
    {


        if(maximalserienumber < serienumber)
        {
            return;
        }

        
        if(numberoftestnings >= numberofeachserie )
        {
            numberoftestnings = 0;
            serienumber++;
            AddmovesofactionRandomnew();
            
            
            return;
        }

        movesinaction[counter]();
        counter++;
        if(counter == movesinaction.Count)
        {
            repetitions++;
            if(cubesolvecheck.solved())
            {
                string content1 = getnameofmoves(movesinaction);
                string content2 = movesinaction.Count.ToString();
                string content3 = repetitions.ToString();
                string[] content = {$"{content1} {content2} {content3}"};
                
                Textwriter.writeToFile(content,nameoffile + serienumber.ToString() );
                if(Randommode)
                {
                    AddmovesofactionRandomnew();
                }
                else
                {
                    addmovesinmovesofaction();
                }
                
                numberoftestnings++;
                repetitions = 0;

            }
            
            counter = 0;
        }
        
    }

    // inte anvenbar
    void addmovesinmovesofactionRandom(int _t)
    {
        movesinaction.Clear();
        int _rannum = (int)UnityEngine.Random.Range(0,Mathf.Pow(18,_t));
        for(int i = 0; i <_t; i++)
        {
            
           
            movesinaction.Add(allmoves[getindex( _rannum, _t)[i]]);
        }
    }

    void addmovesinmovesofaction()
    {
        dragnumer++;
        movesinaction.Clear();
        for(int i = 0; i <serienumber; i++)
        {
            movesinaction.Add(allmoves[getindex(dragnumer, serienumber)[i]]);
        }
        
    }


    void AddmovesofactionRandomnew()
    {
        movesinaction.Clear();
        for(int i=0; i<serienumber; i++)
        {
            int _rannum = (int)UnityEngine.Random.Range(0,18);
            movesinaction.Add(allmoves[_rannum]);
        }
    } 

    string getnameofmoves(List<Action> items)
    {
        string name = "";
        for(int i = 0; i<items.Count; i++)
        {
            name +=  items[i].Method.Name + ",";
            
        }
        return name;
    }

    
    int[] getindex(int tal, int antal)
    {
        
        int[] talföljd = new int[antal];
        talföljd[0] = tal%18;
        int sum = talföljd[0];

        for(int n = 2; n<antal+1; n++)
        {
            talföljd[n-1] = ((tal-sum)/(int)(Mathf.Pow(18,n-1)))%18;
            sum += talföljd[n-1]*(int)Mathf.Pow(18,n-1);
        }
        return talföljd;

    }
        
    
}
