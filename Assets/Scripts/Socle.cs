using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Socle : MonoBehaviour
{
    [SerializeField]
    public int correct = 0;

    [SerializeField]
    public RectTransform bouton;

    [SerializeField]
    public GameObject table;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correct == 4)
        {
            //énigme résolue, activer le bouton 
            bouton.gameObject.SetActive(true);
            table.SetActive(true);
            correct++;
        }
    }

    public void correctPlus()
    {
        correct++;
    }

    public void correctMoins()
    {
        correct--;
    }
}
