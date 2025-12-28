using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManage : MonoBehaviour
{
    public void Self()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Deck()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    
    public void Salir()
    {
        Debug.Log("[MENU] Saliendo del juego...");
        Application.Quit();
    }
}
