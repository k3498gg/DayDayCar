using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TDCarManager : MonoBehaviour {

    public List<GameObject> cars;

    void Start()
    {
        //RegisterClickEventHandler();
    }

    //void RegisterClickEventHandler()
    //{
    //    foreach (GameObject go in cars)
    //    {
    //        UIEventListener.Get(go).onClick = ClickCarEventHandler;
    //    }
    //}

    //private void ClickCarEventHandler(GameObject target)
    //{
    //    Debug.LogError(target.name);
    //    if (UIManager.m_Instance != null)
    //    {
    //        UIManager.m_Instance.TopTransformMoveOut();
    //        UIManager.m_Instance.BomTransformMoveOut();
    //    }
    //}
}
