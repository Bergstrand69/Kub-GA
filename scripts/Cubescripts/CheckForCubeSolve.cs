using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCubeSolve : MonoBehaviour
{
    

    public static Vector3 rotationPoint;

    //hörn bitar
    public GameObject ha;
    public GameObject hb;
    public GameObject hc;
    public GameObject hd;
    public GameObject hu;
    public GameObject hv;
    public GameObject hw;
    public GameObject hx;

    //kanter bitar
    public GameObject kx;
    public GameObject ku;
    public GameObject kw;
    public GameObject kv;
    public GameObject kc;
    public GameObject ka;
    public GameObject kb;
    public GameObject kd;
    public GameObject kj;
    public GameObject kt;
    public GameObject kr;
    public GameObject kl;

    //mitten bitar
    public GameObject mw;
    public GameObject mb;
    public GameObject mgu;
    public GameObject mr;
    public GameObject mgr;
    public GameObject mo;

    
    public static List<GameObject> kubHörnLista = new List<GameObject>();
    public static List<GameObject> mitenBittar = new List<GameObject>();

    public static List<GameObject> allaBitar = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        
        rotationPoint = gameObject.transform.position;
        // hörn bitar
        kubHörnLista.Add(ha);
        kubHörnLista.Add(hb);
        kubHörnLista.Add(hc);
        kubHörnLista.Add(hd);
        kubHörnLista.Add(hu);
        kubHörnLista.Add(hv);
        kubHörnLista.Add(hw);
        kubHörnLista.Add(hx);

        //kanter bitar
        kubHörnLista.Add(ku);
        kubHörnLista.Add(kv);
        kubHörnLista.Add(kw);
        kubHörnLista.Add(kx);
        kubHörnLista.Add(ka);
        kubHörnLista.Add(kb);
        kubHörnLista.Add(kc);
        kubHörnLista.Add(kd);
        kubHörnLista.Add(kj);
        kubHörnLista.Add(kt);
        kubHörnLista.Add(kr);
        kubHörnLista.Add(kl);

        //mitten bitar
        mitenBittar.Add(mw);
        mitenBittar.Add(mb);      
        mitenBittar.Add(mgu);
        mitenBittar.Add(mr);
        mitenBittar.Add(mgr);
        mitenBittar.Add(mo);

        // hörn bitar
        allaBitar.Add(ha);
        allaBitar.Add(hb);
        allaBitar.Add(hc);
        allaBitar.Add(hd);
        allaBitar.Add(hu);
        allaBitar.Add(hv);
        allaBitar.Add(hw);
        allaBitar.Add(hx);

        //kanter bitar
        allaBitar.Add(ku);
        allaBitar.Add(kv);
        allaBitar.Add(kw);
        allaBitar.Add(kx);
        allaBitar.Add(ka);
        allaBitar.Add(kb);
        allaBitar.Add(kc);
        allaBitar.Add(kd);
        allaBitar.Add(kj);
        allaBitar.Add(kt);
        allaBitar.Add(kr);
        allaBitar.Add(kl);

        //mitten bitar
        allaBitar.Add(mw);
        allaBitar.Add(mb);      
        allaBitar.Add(mgu);
        allaBitar.Add(mr);
        allaBitar.Add(mgr);
        allaBitar.Add(mo);
        
        
        
    }


   

    

    bool CheckMidPisses()
    {
    
        bool b = Vector3.Distance(mb.transform.position,ka.transform.position) == 1 && Vector3.Distance(mb.transform.position,kr.transform.position) == 1;
        bool w = Vector3.Distance(mw.transform.position,ka.transform.position) == 1 && Vector3.Distance(mw.transform.position,kb.transform.position) == 1;
        bool gu = Vector3.Distance(mgu.transform.position,kx.transform.position) == 1 && Vector3.Distance(mgu.transform.position,ku.transform.position) == 1;
        bool o = Vector3.Distance(mo.transform.position,kd.transform.position) == 1 && Vector3.Distance(mo.transform.position,kx.transform.position) == 1;
        bool r = Vector3.Distance(mr.transform.position,kb.transform.position) == 1 && Vector3.Distance(mr.transform.position,kv.transform.position) == 1;
        bool gr = Vector3.Distance(mgr.transform.position,kc.transform.position) == 1 && Vector3.Distance(mgr.transform.position,ku.transform.position) == 1;

        //Debug.Log(b + " b");
        //Debug.Log(w + " w");
        //Debug.Log(gu + " gu");
        //Debug.Log(o + " o");
        //Debug.Log(r + " r");
        //Debug.Log(gr+ " gr");
        if(b && w && gu && o && r && gr)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public bool solved()
    {

        
        int x = 0;
        for (int k = 0; k<kubHörnLista.Count; k++)
        {
            if(kubHörnLista[k].transform.rotation.eulerAngles == ha.transform.rotation.eulerAngles)
            {
            
            x++;
            }
        }
        if(x == kubHörnLista.Count && CheckMidPisses())
        {
        
            return true;
        }
        else
        {
        
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
       
       
        
    }
}
