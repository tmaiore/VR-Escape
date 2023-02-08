using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomLight : MonoBehaviour
{
    public static RoomLight instance = null;


    [SerializeField]
    private GameObject DayRoom;

    [SerializeField]
    private GameObject RedRoom;

    [SerializeField]
    private GameObject NightRoom;

    [SerializeField] private Transform common;

    [SerializeField]
    private GameObject Cube;

    [SerializeField]
    private GameObject Cylindre;

    [SerializeField]
    private GameObject Pyramide;

    [SerializeField]
    private GameObject Sphere;


    private static void Show(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    private static void Hide(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    void Awake()
	{
        instance = this;
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
        Show(Sphere);
        Show(Cylindre);
        Show(Pyramide); 
        Show(Cube);
        Hide(RedRoom);
        Hide(NightRoom);

    }

    public void ShowRedRoom()
	{
        Hide(DayRoom);
        Hide(Sphere);
        Hide(Cylindre);
        Hide(Pyramide);
        Hide(Cube);
        Show(RedRoom);
        Hide(NightRoom);
    }

    public void ShowNightRoom()
	{
        Hide(DayRoom);
        Hide(Sphere);
        Hide(Cylindre);
        Hide(Pyramide);
        Hide(Cube);
        Hide(RedRoom);
        Show(NightRoom);
    }

}