using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject DuringGame;
    public GameObject Win;
    public GameObject Lose;

    void Start()
    {
        DuringGame.SetActive(true);
        Win.SetActive(false);
        Lose.SetActive(false);
    }
    public void Winner()
    {
        DuringGame.SetActive(false);
        Win.SetActive(true);
        Lose.SetActive(false);
    }
    public void Looser()
    {
        DuringGame.SetActive(false);
        Win.SetActive(false);
        Lose.SetActive(true);
    }
}
