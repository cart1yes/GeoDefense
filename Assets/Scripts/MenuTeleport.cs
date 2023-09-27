using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuTeleport : MonoBehaviour
{
    public Image controls;

    public void OnPlayClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnControlsClick()
    {
        controls.gameObject.SetActive(true);
    }

    public void CloseMenu()
    {
        controls.gameObject.SetActive(false);
    }
}
