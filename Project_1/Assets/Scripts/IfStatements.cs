using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 4;
    public int b = 5;
    public int c = 10;
    public string password = "Friend";
    public bool lightsOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (a+b < c)
        {
            print(message: true);
        }
        else
        {
            print( message: false);
        }
        
        if (password != "OU812")
        {
            print(message: true);
        }

        if (!lightsOn)
        {
            print(message: true);
        }
    }
    
}
