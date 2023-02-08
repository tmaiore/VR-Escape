using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeft = 10.0f;

    [SerializeField]
    private SwitchScene switchScene;

    [SerializeField]
    private GameObject heroic;

    [SerializeField]
    private GameObject braveheart;

    void Update()
    {
        if (timeLeft < 0)
        {
            switchScene.LoadScene(3);
        }
        else
		{
            timeLeft -= Time.deltaTime;
            //Debug.Log(timeLeft);
        }
        if(timeLeft < 260)
        {
            heroic.SetActive(true);
        }
        if(timeLeft < 140)
        {
            braveheart.SetActive(true);
        }
    }
}
