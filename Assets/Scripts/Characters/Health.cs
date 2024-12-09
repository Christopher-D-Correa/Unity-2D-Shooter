using UnityEngine;
using UnityEngine.Events;

public class Health

{
    public UnityEvent OnDied;
    private float healthValue;

    public void DecreaseHealth(float damageParameter)
    {
        healthValue -= damageParameter;
        Debug.Log("Health decreasing to: " + healthValue);
        //Update The UI
        //Check If Is Dead
        if(IsDead())
        {
            OnDied.Invoke();
            //Spawn Explosion
            //Destroy Object
            //Multiply 
        }
    }

    public void IncreaseHealth(float increaseParameter)
    {
        healthValue += increaseParameter;
    }

    public bool IsDead()
    {

        return healthValue <=0;
    }


    public float GetHealthValue()

    {
        return healthValue;
    }

    public Health()
    //Health value always equals 100
    {
        healthValue = 100;
        OnDied = new UnityEvent();
    }
      

    public Health(float initialHealth)
    {
        healthValue = initialHealth;
        OnDied = new UnityEvent();
        //This parameter allows us to change around
        //playerHealth = new Health() in Game Manager
    }


}
