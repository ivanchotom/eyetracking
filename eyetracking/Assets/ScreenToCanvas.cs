using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class ScreenToCanvas : MonoBehaviour
{
    public RectTransform m_parent;
    public Camera m_uiCamera;
    public RectTransform m_image;
    Vector2 gazeboi;
    bool ShowFovea = false;
    public GameObject foveaSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gazeboi = TobiiAPI.GetGazePoint().Screen;

        if (Input.GetKeyDown("b"))
        {
            ShowFovea = true;
            foveaSprite.SetActive(true);
        }

        if (Input.GetKeyDown("v"))
        {
            ShowFovea = false;
            foveaSprite.SetActive(false);

        }

        if (ShowFovea == true)
        {
            Vector2 anchoredPos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(m_parent, gazeboi, m_uiCamera, out anchoredPos);
            m_image.anchoredPosition = anchoredPos;
        }
    }
}
