using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PBScript : MonoBehaviour
{
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Good()
	{
        image.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
    }
}
