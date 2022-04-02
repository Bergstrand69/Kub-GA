using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputMovesSystem : MonoBehaviour
{
    public GameObject start;
    public InputField textRuta;
    public Text felinmatningtext;
    
    
    // Start is called before the first frame update
    void Start()
    {
        textRuta.onEndEdit.AddListener(delegate{getTextFromtf(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void getTextFromtf()
    {
        felinmatningtext.text = "";
        CubeRotationScript.dragLista.Clear();
        string[] _wordList = textRuta.text.Split(',');

    

        for(int i= 0; i<_wordList.Length; i++)
        {
            switch(_wordList[i])
            {
                case "U":
                    start.GetComponent<CubeRotationScript>().AddU();
                    break; 
                case "U_":
                    start.GetComponent<CubeRotationScript>().AddU_();
                    break;
                case "R":
                    start.GetComponent<CubeRotationScript>().AddR();
                    break;
                case "R_":
                    start.GetComponent<CubeRotationScript>().AddR_();
                    break;
                case "L":
                    start.GetComponent<CubeRotationScript>().AddL();
                    break;
                case "L_":
                    start.GetComponent<CubeRotationScript>().AddL_();
                    break;
                case "B":
                    start.GetComponent<CubeRotationScript>().AddB();
                    break;
                case "B_":
                    start.GetComponent<CubeRotationScript>().AddB_();
                    break;
                case "D":
                    start.GetComponent<CubeRotationScript>().AddD();
                    break;
                case "D_":
                    start.GetComponent<CubeRotationScript>().AddD_();
                    break;
                case "F":
                    start.GetComponent<CubeRotationScript>().AddF();
                    break;
                case "F_":
                    start.GetComponent<CubeRotationScript>().AddF_();
                    break;
                case "M":
                    start.GetComponent<CubeRotationScript>().AddM();
                    break;
                case "M_":
                    start.GetComponent<CubeRotationScript>().AddM_();
                    break;
                case "S":
                    start.GetComponent<CubeRotationScript>().AddS();
                    break;
                case "S_":
                    start.GetComponent<CubeRotationScript>().AddS_();
                    break;
                case "X":
                    start.GetComponent<CubeRotationScript>().AddX();
                    break;
                case "X_":
                    start.GetComponent<CubeRotationScript>().AddX_();
                    break;
                case "E":
                    start.GetComponent<CubeRotationScript>().AddE();
                    break;
                case "E_":
                    start.GetComponent<CubeRotationScript>().AddE_();
                    break;
                case "":
                    break;
                default:
                    felinmatningtext.text = $"Fel inmatning på nummer {i+1}";
                    
                    break;



            }

        


        }
          
    }
    public void resestaDrag()
    {
    CubeRotationScript.dragLista.Clear();
    textRuta.text = "";
    }

    void Charchange(string _x)
    {
        
        int charIndex = textRuta.text.IndexOf (_x);
        textRuta.text = textRuta.text.Replace (textRuta.text [charIndex].ToString(), "");
       
    }





}
