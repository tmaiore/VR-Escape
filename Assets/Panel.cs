using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{

    public static Panel instance = null;

    [SerializeField]
    public int correct = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correct == 16)
        {
            //énigme résolue

            correct++;
        }
    }
}
