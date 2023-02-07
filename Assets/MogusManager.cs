using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class MogusManager : MonoBehaviour
{

    XRSocketInteractor interactor;

    [SerializeField]
    private string tagg;

    [SerializeField]
    private int correct = 0;

    // Start is called before the first frame update
    void Start()
    {
        interactor= GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(correct == 16)
        {
            //énigme résolue

            correct++;
        }
    }

    public void OnSelect(SelectEnterEventArgs args)
    {
        IXRSelectInteractable objName = interactor.GetOldestInteractableSelected();
        GameObject obj = objName.transform.gameObject;
        tagg = obj.tag;

        switch(tagg)
        {
            case "red":
                if (interactor.tag == "redPanel")
                {
                    correct++;
                }
                break;

            case "white":
                if (interactor.tag == "whitePanel")
                {
                    correct++;
                }
                break;

            case "grey":
                if (interactor.tag == "greyPanel")
                {
                    correct++;
                }
                break;

            default: break;

        }
    }


    public void OnDeselect(SelectExitEventArgs args)
    {
        tagg = "";
        correct--;
    }


}
