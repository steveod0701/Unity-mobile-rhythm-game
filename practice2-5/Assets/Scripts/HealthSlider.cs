using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    public float s_StartingHealth = 100f;
    public Slider s_Slider;
    public Image s_Fillimage;
    public Color s_FullHealthColor=Color.green;
    public Color s_ZeroHealthColor=Color.red;
    public AudioSource audioSource;
    public GameObject DeathPanel;

    public float s_CurrentHealth;

    private void Awake()
    {
        s_CurrentHealth = s_StartingHealth;
        DeathPanel.SetActive(false);

    }

    public void TakeDamage(float amount)
    {
        s_CurrentHealth -= amount;
        SetHealthUI();
    }

    public void RestoreHealthP()
    {
        if (s_CurrentHealth <= 95)
        {
            s_CurrentHealth += 5;
        }
        else
        {
            s_CurrentHealth = 100;
        }
        SetHealthUI();
    }
    
    public void SetHealthUI()
    {
        s_Slider.value = s_CurrentHealth;
        s_Fillimage.color = Color.Lerp(s_ZeroHealthColor, s_FullHealthColor, s_CurrentHealth / s_StartingHealth);
        if (s_CurrentHealth < 1)
        {
            audioSource.Pause();
            DeathPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
