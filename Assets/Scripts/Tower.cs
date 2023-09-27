using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tower : MonoBehaviour
{
    [Header("Tower Config")]
    public GameObject Barrel;
    public bool Placeholder;
    public bool Placed;
    public GameObject CurrentBullet;
    public GameObject Bullet;
    public GameObject Bullet1;
    public GameObject Bullet2;
    public string Name;
    public float FireRate;
    public float Range;
    public GameObject RangeIcon;
    public string BulletType;
    public int BulletAmt;
    public Transform target;
    [Header("Upgrades")]
    public GameObject Upgarde1;
    public GameObject Upgarde2;
    public int UpgradeVal;

    [Header("Tower Debug")]
    public bool MultiReady;

    private void Awake()
    {
        if (gameObject.GetComponent<Tower>().Name == "GunnerClone" || gameObject.GetComponent<Tower>().Name == "SplitClone" || gameObject.GetComponent<Tower>().Name == "RapidFireClone" || gameObject.GetComponent<Tower>().Name == "LaserClone" || gameObject.GetComponent<Tower>().Name == "SniperClone" || gameObject.GetComponent<Tower>().Name == "ZapperClone")
        {
            Placeholder = true;
            Placed = false;
        }
        else
        {
            Placeholder = false;
            Placed = true;
            CurrentBullet = Bullet;
            RangeIcon.gameObject.transform.localScale += new Vector3(Range * 2, Range * 2, 0.2f);
            StartCoroutine(Attack());
        }

        UpgradeVal = 0;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }

    // Update is called once per frame
    void Update()
    {
        if (UpgradeVal == 2)
        {
            CurrentBullet = Bullet2;
        }
        else if (UpgradeVal == 1)
        {
            CurrentBullet = Bullet1;
        }
        else if (UpgradeVal == 0)
        {
            CurrentBullet = Bullet;
        }

        if (Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast(clickPosition, Vector2.zero, Mathf.Infinity);

            if (hit2D.collider != null)
            {
                if (hit2D.collider.CompareTag("Tower"))
                {
                    if (GameObject.Find("WaveManager").GetComponent<Gui>().CurrentTower != null)
                    {
                        GameObject.Find("WaveManager").GetComponent<Gui>().CloseMenu();
                        GameObject.Find("WaveManager").GetComponent<Gui>().CurrentTower = hit2D.collider.gameObject;
                    }
                    else
                    {
                        GameObject.Find("WaveManager").GetComponent<Gui>().CurrentTower = hit2D.collider.gameObject;
                    }

                    if (hit2D.collider.GetComponent<Tower>().Name == "Gunner")
                    {
                        GameObject.Find("WaveManager").GetComponent<Gui>().NameVal = "Gunner";

                        if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 2)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 0;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "4";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.25";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "A Standard Tower";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 1)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 1300;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "4";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "4";
                                GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "A Standard Tower";

                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 0)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 500;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "3";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "2";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "A Standard Tower";
                        }
                        //GameObject.Find("WaveManager").GetComponent<Gui>().CurrentTower = hit2D.collider.gameObject;
                        GameObject.Find("WaveManager").GetComponent<Gui>().UpgradeMenu.gameObject.SetActive(true);
                    }
                    else if (hit2D.collider.GetComponent<Tower>().Name == "SplitShot")
                    {
                        GameObject.Find("WaveManager").GetComponent<Gui>().NameVal = "SplitShot";
                        if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 2)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 0;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "3";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.85";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "4";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Multiple Bullets At Once";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 1)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 1400;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "3";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.9";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "2";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Multiple Bullets At Once";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 0)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 600;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "2";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "1";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "1";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Multiple Bullets At Once";
                        }
                        //GameObject.Find("WaveManager").GetComponent<Gui>().CurrentTower = hit2D.collider.gameObject;
                        GameObject.Find("WaveManager").GetComponent<Gui>().UpgradeMenu.gameObject.SetActive(true);
                    }
                    else if (hit2D.collider.GetComponent<Tower>().Name == "RapidFire")
                    {
                        GameObject.Find("WaveManager").GetComponent<Gui>().NameVal = "RapidFire";
                        if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 2)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 0;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.15";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Multiple Bullets At Once";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 1)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 2500;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "4";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.25";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "3";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Multiple Bullets At Once";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 0)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 1250;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "3";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.25";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "2";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Bullets At A Rapid Rate";
                        }
                        //GameObject.Find("WaveManager").GetComponent<Gui>().CurrentTower = hit2D.collider.gameObject;
                        GameObject.Find("WaveManager").GetComponent<Gui>().UpgradeMenu.gameObject.SetActive(true);
                    }
                    else if (hit2D.collider.GetComponent<Tower>().Name == "Laser")
                    {
                        GameObject.Find("WaveManager").GetComponent<Gui>().NameVal = "Laser";
                        if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 2)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 0;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.005";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "12";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "The Final Boss For The Shapes";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 1)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 1;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.01";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "8";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "The Final Boss For The Shapes";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 0)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 20000;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "0.01";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "The Final Boss For The Shapes";
                        }
                        //GameObject.Find("WaveManager").GetComponent<Gui>().CurrentTower = hit2D.collider.gameObject;
                        GameObject.Find("WaveManager").GetComponent<Gui>().UpgradeMenu.gameObject.SetActive(true);
                    }
                    else if (hit2D.collider.GetComponent<Tower>().Name == "Sniper")
                    {
                        GameObject.Find("WaveManager").GetComponent<Gui>().NameVal = "Sniper";
                        if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 2)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 0;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "2";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "75";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Strong Bullets At Slow Speeds";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 1)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 3300;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "2.5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "40";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Strong Bullets At Slow Speeds";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 0)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 1750;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "20";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "3";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "25";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Fires Strong Bullets At Slow Speeds";
                        }
                        //GameObject.Find("WaveManager").GetComponent<Gui>().CurrentTower = hit2D.collider.gameObject;
                        GameObject.Find("WaveManager").GetComponent<Gui>().UpgradeMenu.gameObject.SetActive(true);
                    }
                    else if (hit2D.collider.GetComponent<Tower>().Name == "Zapper")
                    {
                        GameObject.Find("WaveManager").GetComponent<Gui>().NameVal = "Zapper";
                        if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 2)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 0;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "6";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "1.5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "1";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Stuns Shapes For A Period Of Time";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 1)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 2500;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "6";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "1.8";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "0";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Stuns Shapes For A Period Of Time";
                        }
                        else if (hit2D.collider.gameObject.GetComponent<Tower>().UpgradeVal == 0)
                        {
                            GameObject.Find("WaveManager").GetComponent<Gui>().PriceVal = 700;
                            GameObject.Find("WaveManager").GetComponent<Gui>().RangeVal = "5";
                            GameObject.Find("WaveManager").GetComponent<Gui>().FirerateVal = "2";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DamageVal = "0";
                            GameObject.Find("WaveManager").GetComponent<Gui>().DescVal = "Stuns Shapes For A Period Of Time";
                        }
                        GameObject.Find("WaveManager").GetComponent<Gui>().UpgradeMenu.gameObject.SetActive(true);
                    }
                }
            }
        }

        if (target)
        {
            Vector3 direction = target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
            Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);

            Barrel.transform.rotation = targetRotation;
        }
    }

    public void ReBullet()
    {
        if (GameObject.Find("WaveManager").GetComponent<WaveManager>().DoneGame == false)
        {
            StopAllCoroutines();
            //print("Reset");
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        if (GameObject.Find("WaveManager").GetComponent<WaveManager>().shapeCount >= 1 && GameObject.Find("WaveManager").GetComponent<Gui>().gameOver == false)
        {
            if (Name != "SplitShot")
            {
                var newBullet = Instantiate(CurrentBullet);
                newBullet.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
                newBullet.GetComponent<BulletScript>().OwningTower = gameObject;
                newBullet.GetComponent<BulletScript>().range = Range;
                newBullet.transform.parent = GameObject.Find("Projectiles").transform;
            }
            else
            {
                var newBullet = Instantiate(CurrentBullet);
                newBullet.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
                newBullet.GetComponent<BulletScript>().OwningTower = gameObject;
                newBullet.GetComponent<BulletScript>().range = Range;
                newBullet.transform.parent = GameObject.Find("Projectiles").transform;

                if (MultiReady == true)
                {
                    for (int i = 0; i < BulletAmt - 1; i++)
                    {
                        newBullet = Instantiate(CurrentBullet);
                        newBullet.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
                        newBullet.GetComponent<BulletScript>().OwningTower = gameObject;
                        newBullet.GetComponent<BulletScript>().range = Range;
                        newBullet.transform.parent = GameObject.Find("Projectiles").transform;
                    }
                }
            }
        }
        yield return new WaitForSeconds(FireRate);
        if (GameObject.Find("WaveManager").GetComponent<WaveManager>().DoneGame == false)
        {
            StartCoroutine(Attack());
        }
    }
}