using System.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Axe : MonoBehaviour
{
    #region Singleton

    public static Axe axe;

    private void Awake()
    {
        axe = this;
    }

    #endregion

    public Text score;
    public int curretScore = 0;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            curretScore++;
            Manager.manager.score.text = "Score " + curretScore;
        }
    }
    public void EnableAxe()
    {
        this.GetComponent<Collider>().enabled = true;
    }

    public void DisableleAxe()
    {
        this.GetComponent<Collider>().enabled = false;
    }
}
