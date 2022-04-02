using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelContentScript2 : MonoBehaviour
{
    
    public Transform panel1;
    public GameObject item;
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(UIManager.MenyIsToggled && Input.GetKeyDown(KeyCode.Backspace))
        {
            earaisItem();
        }

    }

    public void newItem(int _d, int _ad, string _ds)
    {
        GameObject _newitem = Instantiate(item,new Vector3(0,0,0), Quaternion.Euler(0,0,0));   
        _newitem.transform.SetParent(panel1,true);
        _newitem.name = x.ToString();
        _newitem.transform.GetChild(0).GetComponent<Text>().text = $"Serie: {_ds} \nDrag: {_d} \nUprepninar: {_d/_ad} \n";
        x++;
        
    }

    public void earaisItem()
    {
        GameObject _item = GameObject.Find(Buttomhightlitingscript.hightlightedbuttom);
        Destroy(_item,0);
        
    }
}
