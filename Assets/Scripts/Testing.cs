using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public Transform prefab;
    public DebugWindow debug;
   
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, new Vector3(2.0F, 0, 2.0F), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CreateBall();
  
        }
    }

    public void CreateBall()
    {
        debug.Write("create ball");
        Instantiate(prefab, new Vector3(2.0F, 2.0F, 2.0F), Quaternion.identity);
    }
}
