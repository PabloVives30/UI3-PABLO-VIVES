using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loginManager : MonoBehaviour
{
    // Start is called before the first frame update

    public InputField inputPassword;
  
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Contra()
    {
        
      if (inputPassword.text == "PabloVives")
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Deniend");
        }
    }
}
