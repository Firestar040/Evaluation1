using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthQuantity
{
    public int _id;
    public int _currenthealth = 10;
    public HealthQuantity(int id)
    {
        _id = id;
    }
    public int ID
    {
        get
        {
            return _id;
        }
    }
    public int CurrentHealth
    {
        set
        {
            _currenthealth = value;
        }
        get
        {
            return _currenthealth;
        }
    }
}
public class HealthController : MonoBehaviour
{
    public Player myplayerid;
    public int id;
    public HealthQuantity myplayer;
    public TextMeshPro currenthealth;
    private void Start()
    {
        myplayer = new HealthQuantity(id);
    }
    public void UpdateTextHealth()
    {
        currenthealth.text = myplayerid.CurrentHealth.ToString();
    }
}
