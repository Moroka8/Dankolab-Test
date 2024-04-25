using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    private Transform content;

    public void AddObjects(List<GameObject> objs) {
        Transform content = gameObject.transform.Find("Content");
        foreach (GameObject obj in objs)
        {
            GameObject block = (GameObject)Instantiate(obj, content);
        }
    }


    public void ClosePanel() {
        Destroy(gameObject);
    }
}
