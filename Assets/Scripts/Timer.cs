using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeft = 10.0f;

    [SerializeField] private SwitchScene switchScene;

    void Update()
    {
        if (timeLeft < 0)
        {
            switchScene.LoadScene(3);
        }
        else
		{
            timeLeft -= Time.deltaTime;
            Debug.Log(timeLeft);
        }
    }
}
