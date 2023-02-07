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
    private Panel panel;

    [SerializeField]
    private string tagg;

    // Start is called before the first frame update
    void Start()
    {
        interactor= GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnSelect(SelectEnterEventArgs args)
    {
        IXRSelectInteractable objName = interactor.GetOldestInteractableSelected();
        if (objName != null)
        {
            GameObject obj = objName.transform.gameObject;
            tagg = obj.tag;

            switch (tagg)
            {
                case "red":
                    if (interactor.tag == "redPanel")
                    {
                        panel.correct++;
                    }
                    break;

                case "white":
                    if (interactor.tag == "whitePanel")
                    {
                        panel.correct++;
                    }
                    break;

                case "grey":
                    if (interactor.tag == "greyPanel")
                    {
                        panel.correct++;
                    }
                    break;

                default: break;

            }
        }
        
    }


    public void OnDeselect(SelectExitEventArgs args)
    {
        tagg = "";
        panel.correct--;
    }


}
