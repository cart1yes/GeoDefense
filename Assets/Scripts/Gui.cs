using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Gui : MonoBehaviour
{
    public GameObject ShapesFolder;
    public GameObject TowersFolder;
    public bool gameOver = false;
    [Header("UI")]
    public WaveManager waveManager;
    public Text Waves;
    public int LifeInt;
    public int TokenInt;
    public bool HasTower;
    public GameObject CurrentTower;
    public GameObject PrevTower;
    public GameObject TowerName;
    public Text Lives;
    public Text Tokens;
    public Vector3 screenPosition;
    public Vector3 worldPosition;
    public Button Cancel;
    public Image GameOverBG;
    public Image VictoryBG;
    [Header("Play Button")]
    public Image StartRound;
    public Image NormalSpeed1;
    public Image NormalSpeed2;
    [Header("UpgradeUI")]
    public Image UpgradeMenu;
    public Text Upgrade;
    public Text Damage;
    public Text Firerate;
    public Text Range;
    public Text TowerDesc;
    public Text CurrentTowerName;
    public string NameVal;
    public int PriceVal;
    public string DamageVal;
    public string FirerateVal;
    public string RangeVal;
    public string DescVal;

    [Header("Tower Amts")]
    private int gunnerAmt;
    private int splitshotAmt;
    private int RapidFireAmt;
    private int LaserAmt;
    private int SniperAmt;
    private int ZapperAmt;

    [Header("Towers")]
    public GameObject Gunner;
    public GameObject SplitShot;
    public GameObject RapidFire;
    public GameObject Laser;
    public GameObject Sniper;
    public GameObject Zapper;

    [Header("Placeholders")]
    public GameObject GPlaceholder;
    public GameObject SSPlaceholder;
    public GameObject RFPlaceHolder;
    public GameObject LPLaceHolder;
    public GameObject SPlaceHolder;
    public GameObject ZPlaceHolder;

    // Start is called before the first frame update
    void Start()
    {
        //TokenInt = 99999999;
        LifeInt = 250;
        Time.timeScale = 1f;
        TokenInt = 400;
        HasTower = false;
    }

    // Update is called once per frame
    void Update()
    {
        Waves.text = "Wave: " + waveManager.Wave.ToString();
        Lives.text = "Lives: " + LifeInt.ToString();
        Tokens.text = "Tokens: " + TokenInt.ToString();

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (HasTower)
            {
                Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit2D = Physics2D.Raycast(clickPosition, Vector2.zero, Mathf.Infinity, LayerMask.GetMask("Tower", "TowerArea"));

                if (hit2D.collider != null)
                {
                    if (hit2D.collider.gameObject.layer == LayerMask.NameToLayer("TowerArea"))
                    {
                        HasTower = false;
                        Cancel.gameObject.SetActive(false);
                        if (TowerName.GetComponent<Tower>().Name == "GunnerClone")
                        {
                            var NewGunner = Instantiate(Gunner, TowerName.transform.position, TowerName.transform.rotation);
                            Destroy(TowerName);
                            NewGunner.transform.parent = TowersFolder.transform;
                            NewGunner.name = NewGunner.name + gunnerAmt.ToString();
                            gunnerAmt++;
                            TokenInt -= 250;
                        }
                        else if (TowerName.GetComponent<Tower>().Name == "SplitClone")
                        {
                            var NewGunner = Instantiate(SplitShot, TowerName.transform.position, TowerName.transform.rotation);
                            Destroy(TowerName);
                            NewGunner.transform.parent = TowersFolder.transform;
                            NewGunner.name = NewGunner.name + splitshotAmt.ToString();
                            splitshotAmt++;
                            TokenInt -= 400;
                        }
                        else if (TowerName.GetComponent<Tower>().Name == "RapidFireClone")
                        {
                            var NewGunner = Instantiate(RapidFire, TowerName.transform.position, TowerName.transform.rotation);
                            Destroy(TowerName);
                            NewGunner.transform.parent = TowersFolder.transform;
                            NewGunner.name = NewGunner.name + RapidFireAmt.ToString();
                            RapidFireAmt++;
                            TokenInt -= 500;
                        }
                        else if (TowerName.GetComponent<Tower>().Name == "LaserClone")
                        {
                            var NewGunner = Instantiate(Laser, TowerName.transform.position, TowerName.transform.rotation);
                            Destroy(TowerName);
                            NewGunner.transform.parent = TowersFolder.transform;
                            NewGunner.name = NewGunner.name + LaserAmt.ToString();
                            LaserAmt++;
                            TokenInt -= 7500;
                        }
                        else if (TowerName.GetComponent<Tower>().Name == "SniperClone")
                        {
                            var NewGunner = Instantiate(Sniper, TowerName.transform.position, TowerName.transform.rotation);
                            Destroy(TowerName);
                            NewGunner.transform.parent = TowersFolder.transform;
                            NewGunner.name = NewGunner.name + SniperAmt.ToString();
                            SniperAmt++;
                            TokenInt -= 1000;
                        }
                        else if (TowerName.GetComponent<Tower>().Name == "ZapperClone")
                        {
                            var NewGunner = Instantiate(Zapper, TowerName.transform.position, TowerName.transform.rotation);
                            Destroy(TowerName);
                            NewGunner.transform.parent = TowersFolder.transform;
                            NewGunner.name = NewGunner.name + ZapperAmt.ToString();
                            ZapperAmt++;
                            TokenInt -= 650;
                        }
                        PrevTower = null;
                        TowerName = null;
                    }
                }
            }
        }

        if (HasTower == true)
        {
            screenPosition = Input.mousePosition;
            screenPosition.z = Camera.main.nearClipPlane + 9.5f;
            worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            TowerName.transform.position = worldPosition;
        }

        if (LifeInt <= 0)
        {
            
            Destroy(ShapesFolder);
            Lives.text = "Lives: 0";
            gameOver = true;
            GameOverBG.gameObject.SetActive(true);
        }

        if (waveManager.DoneGame == true && waveManager.shapeCount <= 0)
        {
            Destroy(ShapesFolder);
            VictoryBG.gameObject.SetActive(true);
        }

        if (UpgradeMenu.gameObject.activeSelf == true)
        {
            
            CurrentTowerName.text = NameVal;
            TowerDesc.text = DescVal;
            CurrentTower.GetComponent<Tower>().RangeIcon.GetComponent<SpriteRenderer>().enabled = true;
            Range.text = "Range: " + RangeVal;
            Firerate.text = "Firerate: " + FirerateVal;
            Damage.text = "Damage: " + DamageVal;
            if (CurrentTower.GetComponent<Tower>().Upgarde2.activeSelf == true)
            {
                Upgrade.text = "Maxxed";
            }
            else
            {
                Upgrade.text = "Upgrade (" + PriceVal.ToString() + ")";
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) && UpgradeMenu.gameObject.activeSelf == true)
        {
            SellTower();
        }

        if (Input.GetKeyDown(KeyCode.E) && UpgradeMenu.gameObject.activeSelf == true)
        {
            UpgradeTower();
        }

        if (Input.GetKeyDown("1"))
        {
            CreateGunner();
        }

        if (Input.GetKeyDown("2"))
        {
            CreateSplitShot();
        }

        if (Input.GetKeyDown("3"))
        {
            CreateRapidFire();
        }

        if (Input.GetKeyDown("4"))
        {
            CreateLaser();
        }

        if (Input.GetKeyDown("5"))
        {
            CreateSniper();
        }

        if (Input.GetKeyDown("6"))
        {
            CreateZapper();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RoundStart();
        }
    }

    public void CancelTower()
    {
        Cancel.gameObject.SetActive(false);
        HasTower = false;
        Destroy(PrevTower);
        PrevTower = null;
        TowerName = null;
    }

    public void CloseMenu()
    {
        CurrentTower.GetComponent<Tower>().RangeIcon.GetComponent<SpriteRenderer>().enabled = false;
        CurrentTower = null;
        UpgradeMenu.gameObject.SetActive(false);
    }

    public void SellTower()
    {
        if (CurrentTower.GetComponent<Tower>().Name == "Gunner")
        {
            TokenInt += 200;
            Destroy(CurrentTower);
        }
        else if (CurrentTower.GetComponent<Tower>().Name == "SplitShot")
        {
            TokenInt += 320;
            Destroy(CurrentTower);
        }
        else if (CurrentTower.GetComponent<Tower>().Name == "RapidFire")
        {
            TokenInt += 400;
            Destroy(CurrentTower);
        }
        else if (CurrentTower.GetComponent<Tower>().Name == "Laser")
        {
            TokenInt += 6000;
            Destroy(CurrentTower);
        }
        else if (CurrentTower.GetComponent<Tower>().Name == "Sniper")
        {
            TokenInt += 800;
            Destroy(CurrentTower);
        }
        else if (CurrentTower.GetComponent<Tower>().Name == "Zapper")
        {
            TokenInt += 520;
            Destroy(CurrentTower);
        }
        CurrentTower = null;
        UpgradeMenu.gameObject.SetActive(false);
    }


    public void UpgradeTower()
    {
        if (Upgrade.text == "Maxxed")
        {
            print("Maxxed");
        }
        else if (TokenInt >= PriceVal)
        {
            TokenInt -= PriceVal;
            if (CurrentTower.GetComponent<Tower>().Upgarde1.activeSelf == true)
            {
                CurrentTower.GetComponent<Tower>().UpgradeVal++;
                CurrentTower.GetComponent<Tower>().Upgarde2.SetActive(true);
                if (CurrentTower.GetComponent<Tower>().Name == "Gunner")
                {
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "4";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.25";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "5";
                    DescVal = "A Standard Tower";

                    CurrentTower.GetComponent<Tower>().Range = 4f;
                    CurrentTower.GetComponent<Tower>().FireRate = 0.25f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "SplitShot")
                {
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "3";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.85";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "2";
                    DescVal = "Shoots Multiple Bullets At Once";

                    CurrentTower.GetComponent<Tower>().Range = 3f;
                    CurrentTower.GetComponent<Tower>().FireRate = 0.85f;
                    CurrentTower.GetComponent<Tower>().BulletAmt = 5;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "RapidFire")
                {
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "5";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.15";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "3";
                    DescVal = "Fires Bullets At A Rapid Rate";

                    CurrentTower.GetComponent<Tower>().Range = 5f;
                    CurrentTower.GetComponent<Tower>().FireRate = 0.15f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "Laser")
                {
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.005";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "12";
                    DescVal = "The Final Boss For The Shapes";

                    CurrentTower.GetComponent<Tower>().Range = 20f;
                    CurrentTower.GetComponent<Tower>().FireRate = 0.005f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "Sniper")
                {
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "3";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "75";
                    DescVal = "Fires Strong Bullets At Slow Speeds";

                    CurrentTower.GetComponent<Tower>().Range = 20f;
                    CurrentTower.GetComponent<Tower>().FireRate = 2f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "Zapper")
                {
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "6";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "1.5";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "3";
                    DescVal = "Stuns Shapes For A Period Of Time";

                    CurrentTower.GetComponent<Tower>().Range = 6f;
                    CurrentTower.GetComponent<Tower>().FireRate = 1.5f;
                }
            }
            else
            {
                CurrentTower.GetComponent<Tower>().UpgradeVal++;
                CurrentTower.GetComponent<Tower>().Upgarde1.SetActive(true);
                if (CurrentTower.GetComponent<Tower>().Name == "Gunner")
                {
                    PriceVal = 1300;
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "4";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.5";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "4";
                    DescVal = "A Standard Tower";

                    CurrentTower.GetComponent<Tower>().Range = 4f;
                    CurrentTower.GetComponent<Tower>().FireRate = 0.5f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "SplitShot")
                {
                    PriceVal = 1400;
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "3";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.9";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "1";
                    DescVal = "Fires Multiple Bullets At Once";

                    CurrentTower.GetComponent<Tower>().Range = 3f;
                    CurrentTower.GetComponent<Tower>().FireRate = 0.9f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "RapidFire")
                {
                    PriceVal = 2500;
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "4";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.25";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "2";
                    DescVal = "Fires Bullets At A Rapid Rate";

                    CurrentTower.GetComponent<Tower>().Range = 4f;
                    CurrentTower.GetComponent<Tower>().FireRate = 0.25f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "Laser")
                {
                    PriceVal = 1;
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.01";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "8";
                    DescVal = "The Final Boss For The Shapes";

                    CurrentTower.GetComponent<Tower>().Range = 20f;
                    CurrentTower.GetComponent<Tower>().FireRate = 0.01f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "Sniper")
                {
                    PriceVal = 3300;
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "2.5";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "40";
                    DescVal = "Fires Strong Bullets At Slow Speeds";

                    CurrentTower.GetComponent<Tower>().Range = 20f;
                    CurrentTower.GetComponent<Tower>().FireRate = 3f;
                }
                else if (CurrentTower.GetComponent<Tower>().Name == "Zapper")
                {
                    PriceVal = 2500;
                    GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "6";
                    GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "1.8";
                    GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "3";
                    DescVal = "Stuns Shapes For A Period Of Time";

                    CurrentTower.GetComponent<Tower>().Range = 6f;
                    CurrentTower.GetComponent<Tower>().FireRate = 1.8f;
                }

            }
            
        }
    }

    public void CreateGunner()
    {
        if (TokenInt >= 250)
        {
            var NewTower = Instantiate(GPlaceholder, screenPosition, transform.rotation);
            HasTower = true;
            TowerName = NewTower;
            NewTower.transform.parent = TowersFolder.transform;
            Cancel.gameObject.SetActive(true);
            if (PrevTower)
            {
                Destroy(PrevTower);
                PrevTower = null;
            }
            PrevTower = TowerName;
        }
    }

    public void CreateSplitShot()
    {
        if (TokenInt >= 400)
        {
            var NewTower = Instantiate(SSPlaceholder, transform.position, transform.rotation);
            HasTower = true;
            TowerName = NewTower;
            NewTower.transform.parent = TowersFolder.transform;
            Cancel.gameObject.SetActive(true);
            if (PrevTower)
            {
                Destroy(PrevTower);
                PrevTower = null;
            }
            PrevTower = TowerName;
        }
        
    }

    public void CreateRapidFire()
    {
        if (TokenInt >= 500)
        {
            var NewTower = Instantiate(RFPlaceHolder, screenPosition, transform.rotation);
            HasTower = true;
            TowerName = NewTower;
            NewTower.transform.parent = TowersFolder.transform;
            Cancel.gameObject.SetActive(true);
            if (PrevTower)
            {
                Destroy(PrevTower);
                PrevTower = null;
            }
            PrevTower = TowerName;
        }
    }

    public void CreateLaser()
    {
        if (TokenInt >= 7500)
        {
            var NewTower = Instantiate(LPLaceHolder, transform.position, transform.rotation);
            HasTower = true;
            TowerName = NewTower;
            NewTower.transform.parent = TowersFolder.transform;
            Cancel.gameObject.SetActive(true);
            if (PrevTower)
            {
                Destroy(PrevTower);
                PrevTower = null;
            }
            PrevTower = TowerName;
        }

    }
    public void CreateSniper()
    {
        if (TokenInt >= 1000)
        {
            var NewTower = Instantiate(SPlaceHolder, screenPosition, transform.rotation);
            HasTower = true;
            TowerName = NewTower;
            NewTower.transform.parent = TowersFolder.transform;
            Cancel.gameObject.SetActive(true);
            if (PrevTower)
            {
                Destroy(PrevTower);
                PrevTower = null;
            }
            PrevTower = TowerName;
        }
    }

    public void CreateZapper()
    {
        if (TokenInt >= 650)
        {
            var NewTower = Instantiate(ZPlaceHolder, transform.position, transform.rotation);
            HasTower = true;
            TowerName = NewTower;
            NewTower.transform.parent = TowersFolder.transform;
            Cancel.gameObject.SetActive(true);
            if (PrevTower)
            {
                Destroy(PrevTower);
                PrevTower = null;
            }
            PrevTower = TowerName;
        }

    }

    public void WReturnToMenu()
    {
        var mapName = SceneManager.GetActiveScene().name;
        MapScript.MapName = mapName;
        SceneManager.LoadScene(0);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RoundStart()
    {
        if (GameObject.Find("WaveManager").GetComponent<WaveManager>().WaveState == "Waiting")
        {
            GameObject.Find("WaveManager").GetComponent<WaveManager>().WaveState = "Start";
            StartRound.gameObject.SetActive(false);
            NormalSpeed1.gameObject.SetActive(true);
            NormalSpeed2.gameObject.SetActive(true);
        }
        else if (GameObject.Find("WaveManager").GetComponent<WaveManager>().WaveState == "Playing" && Time.timeScale == 1f)
        {
            NormalSpeed1.GetComponent<Image>().color = Color.yellow;
            NormalSpeed2.GetComponent<Image>().color = Color.yellow;
            Time.timeScale = 3f;
        }
        else if (GameObject.Find("WaveManager").GetComponent<WaveManager>().WaveState == "Playing" && Time.timeScale == 3f)
        {
            NormalSpeed1.GetComponent<Image>().color = Color.white;
            NormalSpeed2.GetComponent<Image>().color = Color.white;
            Time.timeScale = 1f;
        }
    }
}
