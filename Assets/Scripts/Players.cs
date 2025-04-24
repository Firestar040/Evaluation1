using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player
{
    public int _id;
    public int _maxhealth = 10;
    public int _currenthealth = 10;
    public Player(int id)
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
        get
        {
            return _currenthealth;
        }
    }
}
public class Players : MonoBehaviour
{
    public PanelManager panelmanager;
    public int id;
    public static event Action UpdateHealth;
    public static event Action ToDefeat;
    public static event Action ToWin;
    public Player myplayer;
    public HealthController myhealthcontroller;
    private Vector2 _direction;
    private void Start()
    {
        myplayer = new Player(id);
    }
    private void Update()
    {
        transform.position = _direction;
        if (myplayer._currenthealth <= 0)
        {
            ToDefeat();
        }
    }
    private void OnEnable()
    {
        UpdateHealth += HealthReduccion;
        UpdateHealth += myhealthcontroller.UpdateTextHealth;

        ToDefeat += panelmanager.Looser;
        ToWin += panelmanager.Winner;
    }
    private void OnDisable()
    {
        UpdateHealth -= HealthReduccion;
        UpdateHealth -= myhealthcontroller.UpdateTextHealth;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            UpdateHealth();
        }
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        _direction = context.ReadValue<Vector2>();
    }
    public void HealthReduccion()
    {
        myplayer._currenthealth--;
    }
}
