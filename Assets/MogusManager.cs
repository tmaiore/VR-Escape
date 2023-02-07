using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class MogusManager : MonoBehaviour
{

    XRSocketInteractor interactor;

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
        GameObject obj = objName.transform.gameObject;
        tagg = obj.tag;
    }


    public void OnDeselect(SelectExitEventArgs args)
    {
        tagg = "";
    }


}
