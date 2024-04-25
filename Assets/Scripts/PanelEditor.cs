using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelEditor : MonoBehaviour
{
    public GameObject obj;
    public Panel panel;
    public Transform canvas;

    public void CreateGamePanel() {
        var objs = GenerateObjects(obj, 5);
        CreatePanel(objs);
    }

    public void CreateSettingsPanel() {
        CreatePanel();
    }

    private void CreatePanel(List<GameObject> objs=null) {
        var p = Instantiate(panel, canvas);
        //В дальнейшем можно передавать список GameObject для наполнения
        //Панели, например, из json
        if (objs != null) p.AddObjects(objs);
    }

    private List<GameObject> GenerateObjects(GameObject obj, int count) {
        List<GameObject> objs = new List<GameObject>();
        for (int i = 0; i < count; ++i) {
            objs.Add(obj);
        }
        return objs;
    }
}
