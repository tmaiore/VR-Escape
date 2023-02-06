using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouleurLumiere : MonoBehaviour
{
    float red = 255f, green = 0f, blue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Coucou");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(red / 255f, green / 255f, blue / 255f);

        if (red == 255 && blue == 0)
        {
            green++;
        }
        if (green == 255 && red != 0)
        {
            red--;
        }
        if (green == 255 && red == 0)
        {
            blue++;
        }
        if (blue == 255 && green != 0)
        {
            green--;
        }
        if (blue == 255 && green == 0)
        {
            red++;
        }
        if (red == 255 && blue != 0)
        {
            blue--;
        }

        // Debug.Log("R : " + red + "G : " + green + "B : " + blue);
    }
}