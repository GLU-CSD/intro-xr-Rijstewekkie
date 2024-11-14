using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float MaxHealth = 100f;
    public float CurrentHealth;
    public Image HealthbarFill;

    public ParticleSystem Hit;
    public ParticleSystem Heal;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthbar()
    {
        HealthbarFill.fillAmount = CurrentHealth / MaxHealth;
    }

    public void TakeDamage(float Amount)
    {
        CurrentHealth -= Amount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        UpdateHealthbar();
        Hit.Play();
    }

    public void RestoreHealth(float Amount)
    {
        CurrentHealth += Amount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        UpdateHealthbar();
        Heal.Play();
    
    }
}
