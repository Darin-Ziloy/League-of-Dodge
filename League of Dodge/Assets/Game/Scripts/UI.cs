using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{
   

    public Image image;
    public Button button;

    void Start()
    {
        
    }
    
    public void DeathScreen()
    {
        image.enabled = true;
        Invoke("ShowButton", 3);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("LOD");
    }

    private void ShowButton()
    {
        button.gameObject.SetActive(true);
    }
}
