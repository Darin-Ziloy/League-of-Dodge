
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Networking;

public class LANplayer : NetworkBehaviour
{

    private Camera sceneCamera;
    [SerializeField]
    Behaviour [] ComponentsToHide;

    private void Start()
    {
        if(!isLocalPlayer)
        {
            for (int  i = 0; i < ComponentsToHide.Length; i++)
                ComponentsToHide [i].enabled = false;
        }
        else 
        {
            sceneCamera = Camera.main;
            if(sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }

        }
    }

    private void OnDisable() 
    {
        if(sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }
}
