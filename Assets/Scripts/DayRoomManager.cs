using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DayRoomManager : MonoBehaviour
{


    [SerializeField]
    private string tagg;

    [SerializeField]
    private Socle socle;


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
            case "Pyramide":
                if (gameObject.tag == "Pyramide")
                {
                    socle.correctPlus();
                }
                break;

            case "Cube":
                if (gameObject.tag == "Cube")
                {
                    socle.correctPlus();
                }
                break;

            case "Cylindre":
                if (gameObject.tag == "Cylinde")
                {
                    socle.correctPlus();
                }
                break;
            case "Sphere":
                if (gameObject.tag == "Sphere")
                {
                    socle.correctPlus();
                }
                break;

            default: break;

        }

    }


    public void OnDeselect(SelectExitEventArgs args)
    {
        tagg = "";
        socle.correctMoins();
    }

}
