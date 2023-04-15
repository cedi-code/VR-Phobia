using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugWindow : MonoBehaviour
{
    
    public Text output;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void Write(string msg)
    {
        output.text += msg + "\n";
    }

    public void Clear()
    {
        output.text = "";
    }
}
