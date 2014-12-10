using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public static UIManager m_Instance;
    public UISprite topSprite;
    public UISprite bomSprite;
    public UISprite btnBackSprite;

    private Vector3 m_TopPos = Vector3.zero;
    private Vector3 m_BomPos = Vector3.zero;
    private Vector3 m_BackBtnPos = Vector3.zero;
    void Awake()
    {
        m_Instance = this;
    }

    void OnDestroy()
    {
        m_Instance = null;
    }

    void Start()
    {
        UIEventListener.Get(btnBackSprite.gameObject).onClick = UIBackShow;
        m_TopPos = topSprite.transform.localPosition;
        m_BomPos = bomSprite.transform.localPosition;
        m_BackBtnPos = btnBackSprite.transform.localPosition;
    }

    private void UIBackShow(GameObject target)
    {
        UIBack();
    }

    private void UIBack()
    {
        iTween.MoveTo(btnBackSprite.gameObject, iTween.Hash("target", btnBackSprite.gameObject, "time", 0.1f, "position", m_BackBtnPos, "islocal", true, "oncomplete", "MoveBackOnComplete", "oncompletetarget", gameObject));
    }


    public void TopTransformMoveBack()
    {
        iTween.MoveTo(topSprite.gameObject, iTween.Hash("target", topSprite.gameObject, "time", 1.0f, "position", m_TopPos, "islocal", true));
    }

    public void TopTransformMoveOut()
    {
        iTween.MoveTo(topSprite.gameObject, iTween.Hash("target", topSprite.gameObject, "time", 1.0f, "position", m_TopPos + new Vector3(0, 150, 0), "islocal", true));
    }

    public void BomTransformMoveBack()
    {
        iTween.MoveTo(bomSprite.gameObject, iTween.Hash("target", bomSprite.gameObject, "time", 1.2f, "position", m_BomPos, "islocal", true));
    }

    public void BomTransformMoveOut()
    {
        iTween.MoveTo(bomSprite.gameObject, iTween.Hash("target", bomSprite.gameObject, "time", 1.2f, "position", m_BomPos - new Vector3(0, 150, 0), "islocal", true, "oncomplete", "MoveOutOnComplete", "oncompletetarget",gameObject));
    }

    private void MoveOutOnComplete()
    {
        iTween.MoveTo(btnBackSprite.gameObject, iTween.Hash("target", btnBackSprite.gameObject, "time", 0.1f, "position", m_BackBtnPos + new Vector3(100, 0, 0), "islocal", true));
    }

    private void MoveBackOnComplete()
    {
        TopTransformMoveBack();
        BomTransformMoveBack();
    }
}
