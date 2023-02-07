using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PBScript : MonoBehaviour
{
    public Image Bouton1;
    public Image Bouton2;
    public Image Bouton3;
    public Image Bouton4;
    public Image Bouton5;

    public int B1 = 0;
    public int B2 = -1;
    public int B3 = -1;
    public int B4 = -1;
    public int B5 = -1;

    private Color32 white = new Color32(255, 255, 255, 255);
    private Color32 black = new Color32(0, 0, 0, 255);
    private Color32 B1_color = new Color32(255, 0, 0, 255);
    private Color32 B2_color = new Color32(255, 0, 255, 255);
    private Color32 B3_color = new Color32(0, 0, 255, 255);
    private Color32 B4_color = new Color32(0, 255, 255, 255);
    private Color32 B5_color = new Color32(0, 255, 0, 255);
    private Color32 yellow = new Color32(255, 255, 0, 255);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Good(Image bouton)
	{
        bouton.color = yellow;
    }

    public void Wrong()
	{
        StartCoroutine(WPPT());
    }

    public void End()
	{
        Bouton1.color = white;
        Bouton2.color = white;
        Bouton3.color = white;
        Bouton4.color = white;
        Bouton5.color = white;
    }

    IEnumerator WPPT()
    {
        Bouton1.color = black;
        Bouton2.color = black;
        Bouton3.color = black;
        Bouton4.color = black;
        Bouton5.color = black;

        B1 = 0;
        B2 = -1;
        B3 = -1;
        B4 = -1;
        B5 = -1;

        yield return new WaitForSeconds(1.0f);


        Bouton1.color = B1_color;
        Bouton2.color = B2_color;
        Bouton3.color = B3_color;
        Bouton4.color = B4_color;
        Bouton5.color = B5_color;
    }

    public void BP1()
	{
        if(B1 == 0)
		{
            Good(Bouton1);
            B1 = 1;
            B2 = 0;
		}
        else if(B1 == 1 && B2 == 1 && B3 == 1 && B4 == 1 && B5 == 1)
		{
            End();
		}
        else
		{
            Wrong();
		}
    }

    public void BP2()
    {
        if (B2 == 0)
        {
            Good(Bouton2);
            B2 = 1;
            B3 = 0;
        }
        else
        {
            Wrong();
        }
    }

    public void BP3()
    {
        if (B3 == 0)
        {
            Good(Bouton3);
            B3 = 1;
            B4 = 0;
        }
        else
        {
            Wrong();
        }
    }

    public void BP4()
    {
        if (B4 == 0)
        {
            Good(Bouton4);
            B4 = 1;
            B5 = 0;
        }
        else
        {
            Wrong();
        }
    }

    public void BP5()
    {
        if (B5 == 0)
        {
            Good(Bouton5);
            B5 = 1;
        }
        else
        {
            Wrong();
        }
    }
}
