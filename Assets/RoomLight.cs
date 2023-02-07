using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomLight : MonoBehaviour
{
    [SerializeField]
    private GameObject DayRoom;

    [SerializeField]
    private GameObject RedRoom;

    [SerializeField]
    private GameObject NightRoom;


    private static void Show(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    private static void Hide(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowDayRoom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDayRoom()
    {
        Show(DayRoom);
        Hide(RedRoom);
        Hide(NightRoom);

    }

    public void ShowRedRoom()
	{
        Hide(DayRoom);
        Show(RedRoom);
        Hide(NightRoom);
    }

    public void ShowNightRoom()
	{
        Hide(DayRoom);
        Hide(RedRoom);
        Show(NightRoom);
    }

}