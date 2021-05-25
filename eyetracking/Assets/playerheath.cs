using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Tobii.Gaming;

public class playerheath : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public Healthbar healthBar;
    public RectTransform m_parent;
    public Camera m_uiCamera;
    public RectTransform m_image;
    Vector2 gazeboi2;
    public GameObject foveaDamage;
    bool damageshown = false;
    float timer;
    public Image foveaHealth;
    public Gradient foveaGradient;
    public Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);


    }

    void ShowDamage(Vector2 gaze)
    {
        timer = 0f;
        damageshown = true;
        foveaHealth.color = foveaGradient.Evaluate(slider.normalizedValue);
        Vector2 anchoredPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(m_parent, gaze, m_uiCamera, out anchoredPos);
        m_image.anchoredPosition = anchoredPos;
    }

    // Update is called once per frame
    void Update()
    {
        gazeboi2 = TobiiAPI.GetGazePoint().Screen;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20f);
            ShowDamage(gazeboi2);
            //Debug.Log("works");
        }

        if (damageshown == true)
        {
            foveaDamage.SetActive(true);
            timer += Time.deltaTime;
        }
       
        if (timer >= 0.5f)
        {
            damageshown = false;
            foveaDamage.SetActive(false);
        }

        //Debug.Log(timer);

        
    }

}
