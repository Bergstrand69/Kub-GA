using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Buttomhightlitingscript : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    // Start is called before the first frame update
    public static string hightlightedbuttom;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnSelect(BaseEventData eventData)
    {
        hightlightedbuttom = this.gameObject.name;
    }

    public void OnDeselect(BaseEventData data)
    {
        hightlightedbuttom = "";
    }

}
