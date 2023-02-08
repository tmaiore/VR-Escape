using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Konami : MonoBehaviour
{

    [SerializeField]
    int haut = 0;
    [SerializeField]
    int bas = 0;
    [SerializeField]
    int gauche = 0;
    [SerializeField]
    int droite = 0;
    [SerializeField]
    int a = 0;
    [SerializeField]
    int b = 0;

    [SerializeField]
    private PlayerCollider player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnKonamiTriggerEntered(string konamiTag)
    {
        switch (konamiTag)
        {
            case "a":
                Debug.Log("a");
                if (haut == 2 && a == 0 && b == 0 && bas == 2 && gauche == 2 && droite == 2)
                {
                    a++;
                    //colorer d
                    break;
                }
                else
                {
                    Reset();
                    break;
                }

            case "b":
                Debug.Log("b");
                if (haut == 2 && a == 1 && b == 0 && bas == 2 && gauche == 2 && droite == 2)
                {
                    b++;
                    //colorer e
                    break;
                }
                else
                {
                    Reset();
                    break;
                }

            case "h":
                Debug.Log("h");
                if (haut == 0 && a==0 && b==0 && bas==0 && gauche==0 && droite==0)
                {
                    haut++;
                    //colorer K
                    break;
                }
                else if(haut == 1 && a == 0 && b == 0 && bas == 0 && gauche == 0 && droite == 0)
                {
                    haut++;
                    //Colorer o(1)
                    break;
                }
                else{
                    Reset();
                    break; 
                }


            case "ba":
                Debug.Log("ba");
                if (haut == 2 && a == 0 && b == 0 && bas == 0 && gauche == 0 && droite == 0)
                {
                    bas++;
                    //colorer n
                    break;
                }
                else if (haut == 2 && a == 0 && b == 0 && bas == 1 && gauche == 0 && droite == 0)
                {
                    bas++;
                    //colorer a
                    break;
                }
                else
                {
                    Reset();
                    break;
                }

            case "g":
                Debug.Log("g");
                if (haut == 2 && a == 0 && b == 0 && bas == 2 && gauche == 0 && droite == 0)
                {
                    gauche++;
                    //colorer m
                    break;
                }
                else if (haut == 2 && a == 0 && b == 0 && bas == 2 && gauche == 1 && droite == 1)
                {
                    gauche++;
                    //colorer C
                    break;
                }
                else
                {
                    Reset();
                    break;
                }

            case "d":
                Debug.Log("d");
                if (haut == 2 && a == 0 && b == 0 && bas == 2 && gauche == 1 && droite == 0)
                {
                    droite++;
                    //colorer i
                    break;
                }
                else if (haut == 2 && a == 0 && b == 0 && bas == 2 && gauche == 2 && droite == 1)
                {
                    droite++;
                    //colorer o(2)
                    break;
                }
                else
                {
                    Reset();
                    break;
                }

            default: break;



        }
    }

    public void Reset()
    {
        haut = 0;
        bas = 0;
        gauche = 0;
        droite = 0;
        a = 0;
        b = 0;

        //Konami au mur éteint
    }


}
