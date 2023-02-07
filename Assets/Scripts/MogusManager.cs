using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class MogusManager : MonoBehaviour
{
    [SerializeField]
    private string tagg;

    [SerializeField] 
    private Panel panel;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnSelect(SelectEnterEventArgs args)
    {
        //IXRSelectInteractable objName = interactor.GetOldestInteractableSelected();
        //GameObject obj = objName.transform.gameObject;
        tagg = args.interactableObject.transform.gameObject.tag;// obj.tag;

        switch (tagg)
        {
            case "red":
                if (gameObject.tag == "redPanel")
                {
                    panel.correctPlus();
                }
                break;

            case "white":
                if (gameObject.tag == "whitePanel")
                {
                    panel.correctPlus();
                }
                break;

            case "grey":
                if (gameObject.tag == "greyPanel")
                {
                    panel.correctPlus();
                }
                break;

            default: break;

        }
        
    }


    public void OnDeselect(SelectExitEventArgs args)
    {
        tagg = "";
       panel.correctMoins();
    }


}
