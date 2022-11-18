using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickSpritescript : MonoBehaviour
{

    public bool clicked = false;
    // Start is called before the first frame update
     public void MouseDown()
    {
        
            clicked = true;
        
        
    }
}
