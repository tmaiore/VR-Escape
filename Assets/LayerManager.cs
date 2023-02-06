using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LayerManager : MonoBehaviour
{
    [SerializeField]
    private RectTransform LayerStartScene;

    [SerializeField]
    private RectTransform Credit;

    private Scene scene;

    private static void Show(Component component)
    {
        component.gameObject.SetActive(true);
    }

    private static void Hide(Component component)
    {
        component.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowLayerStartScene();
        scene = SceneManager.GetActiveScene();
    }

    public void ShowLayerStartScene()
    {
        Show(LayerStartScene);
        Hide(Credit);
    }

    public void ShowCredit()
    {
        Hide(LayerStartScene);
        Show(Credit);
    }
}
