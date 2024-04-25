using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public Transform content;

    public void AddObjects(List<GameObject> objs) {
        foreach (GameObject obj in objs)
        {
            GameObject block = (GameObject)Instantiate(obj, content);
        }
    }

    public void ClosePanel() {
        Destroy(gameObject);
    }
}
