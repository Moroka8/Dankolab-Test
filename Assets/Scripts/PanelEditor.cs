using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelEditor : MonoBehaviour
{
    public GameObject prefab;
    public Transform panel;
    public int count = 5;

    public void AddObject()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject block = (GameObject)Instantiate(prefab);
            block.transform.SetParent(panel.transform, false);
        }
    }

    public void ClearPanel() {
        int childCount = panel.childCount;
        for (int i = childCount - 1; i >= 0; i--)
        {
            Transform child = panel.GetChild(i);
            Destroy(child.gameObject);
        }
    }
}
