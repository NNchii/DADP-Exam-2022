using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToBedroom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveTobedroom()
    {
        SceneManager.LoadScene(2);
    }
    public void MoveToKitchen()
    {
        SceneManager.LoadScene(4);
    }
}
