using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectMap : MonoBehaviour
{
    public string SelectedMap;
    public Button Self;
    public Image check;
    public Image locked;
    public void Awake()
    {
        SelectedMap = gameObject.name;
    }

    public void Update()
    { 
        if (locked != null)
        {
            if (GameObject.Find("Easy1").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Easy2").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Easy3").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Easy4").GetComponent<SelectMap>().check.gameObject.activeSelf == true)
            {
                print("row1");
                if (GameObject.Find("Medium1").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Medium2").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Medium3").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Medium4").GetComponent<SelectMap>().check.gameObject.activeSelf == true)
                {
                    print("row2");
                    if (GameObject.Find("Hard1").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Hard2").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Hard3").GetComponent<SelectMap>().check.gameObject.activeSelf == true && GameObject.Find("Hard4").GetComponent<SelectMap>().check.gameObject.activeSelf == true)
                    {
                        print("row3");
                        if (Self.interactable == false)
                        {
                            locked.gameObject.SetActive(false);
                            Self.interactable = true;
                        }
                    }
                }
            }
        }

        if (PlayerPrefs.GetString(gameObject.name) == "True" && check.gameObject.activeSelf == false)
        {
            check.gameObject.SetActive(true);
        }

    }

    // Start is called before the first frame update
    public void OnClick()
    {
        SceneManager.LoadScene(SelectedMap);
    }
}
