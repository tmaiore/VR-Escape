using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [SerializeField]
    public RectTransform bouton;

    [SerializeField]
    public Image K;
    public Image O;
    public Image N;
    public Image A;
    public Image M;
    public Image I;
    public Image C;
    public Image O1;
    public Image D;
    public Image E;

    private Color32 black = new Color32(0, 0, 0, 255);
    private Color32 green = new Color32(0, 255, 0, 255);

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
                    D.color = green;
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
                    E.color = green;
                    bouton.gameObject.SetActive(true);
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
                    K.color = green;
                    break;
                }
                else if(haut == 1 && a == 0 && b == 0 && bas == 0 && gauche == 0 && droite == 0)
                {
                    haut++;
                    //Colorer o(1)
                    O.color = green;
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
                    N.color = green;
                    break;
                }
                else if (haut == 2 && a == 0 && b == 0 && bas == 1 && gauche == 0 && droite == 0)
                {
                    bas++;
                    //colorer a
                    A.color = green;
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
                    M.color = green;
                    break;
                }
                else if (haut == 2 && a == 0 && b == 0 && bas == 2 && gauche == 1 && droite == 1)
                {
                    gauche++;
                    //colorer C
                    C.color = green;
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
                    I.color = green;
                    break;
                }
                else if (haut == 2 && a == 0 && b == 0 && bas == 2 && gauche == 2 && droite == 1)
                {
                    droite++;
                    //colorer o(2)
                    O1.color = green;
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
        K.color = black;
        O.color = black;
        N.color = black;
        A.color = black;
        M.color = black;
        I.color = black;
        C.color = black;
        O1.color = black;
        D.color = black;
        E.color = black;
}


}
