using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string scene;
    public char _char;
   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("this is startfunction");
        Name();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Funtion");

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("terrain");
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene("Sample");
        }
    }

    void FixedUpdate()
    {
        
    }

    void Awake()
    {
        Debug.Log("Awake function");
    }

    void Name()
    {
        print("My name is Raaj");
    }



}
