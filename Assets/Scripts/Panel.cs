using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Panel : MonoBehaviour
{


    [SerializeField]
    public int correct = 0;

    [SerializeField]
    public int incorrect = 0;

    [SerializeField] 
    public int notPlaced = 16;

    [SerializeField]
    public RectTransform bouton;

    AudioSource source;
    AudioClip clip;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (correct == 16)
        {
            //énigme résolue, activer le bouton 
            source = GetComponent<AudioSource>();
            source.PlayOneShot(clip);
            bouton.gameObject.SetActive(true);
            
            correct++;
        }
    }

    public void correctPlus()
    {
        correct++;
        notPlaced--;
    }

    public void correctMoins()
    {
        correct--;
        notPlaced++;
    }

    public void incorrectPlus()
    {
        incorrect++;
        notPlaced--;
    }

    public void incorrectMoins()
    {
        incorrect--;
        notPlaced++;
    }

}
