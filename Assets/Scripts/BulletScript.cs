using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float BulletSpeed = 1;
    public int Damage;
    public float range;
    private GameObject[] enemies;
    private Transform targetedEnemy;
    public GameObject OwningTower;
    public string bulletType;
    public int BulletTier;
    private SpriteRenderer Sprite;
    private bool HasHit = false;
    private float StunTime;

    void Awake()
    {
        Sprite = gameObject.GetComponent<SpriteRenderer>();
        enemies = GameObject.FindGameObjectsWithTag("Shape");
        targetedEnemy = enemies[Random.Range(0, enemies.Length)].transform;

        if (bulletType == "Electric" && BulletTier == 1)
        {
            StunTime = 2f;
        }
        else if (bulletType == "Electric" && BulletTier == 2)
        {
            StunTime = 3.5f;
        }
        else if (bulletType == "Electric" && BulletTier == 3)
        {
            StunTime = 5.5f;
        }
    }

    void Update()
    {
        if (targetedEnemy && OwningTower != null)
        {
            var distance = OwningTower.transform.position - targetedEnemy.position;
            int RangeInt = (int)range;
            if (distance.magnitude <= RangeInt)
            {
                if (targetedEnemy == null)
                {
                    Destroy(gameObject);
                }
                else
                {
                    if (OwningTower.GetComponent<Tower>().Name == "SplitShot")
                    {
                        OwningTower.GetComponent<Tower>().MultiReady = true;
                    }

                    float step = BulletSpeed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, targetedEnemy.position, step);

                    Vector3 direction = targetedEnemy.position - transform.position;
                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                    Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);

                    gameObject.transform.rotation = targetRotation;

                    if (OwningTower)
                    {
                        OwningTower.GetComponent<Tower>().target = targetedEnemy;
                    }

                    if (gameObject.transform.position == targetedEnemy.transform.position)
                    {
                        if (bulletType == "Default" && HasHit == false)
                        {
                            HasHit = true;
                            targetedEnemy.GetComponent<ShapeMovement>().Health -= Damage;
                            targetedEnemy.GetComponent<ShapeMovement>().Attacked();

                            if (targetedEnemy.GetComponent<ShapeMovement>().Health <= 0)
                            {
                                GameObject.Find("WaveManager").GetComponent<Gui>().TokenInt += targetedEnemy.GetComponent<ShapeMovement>().MaxHealth;
                            }
                            Destroy(gameObject);
                        }
                        else if (bulletType == "Electric" && HasHit == false)
                        {
                            HasHit = true;
                            targetedEnemy.GetComponent<ShapeMovement>().Health -= Damage;
                            targetedEnemy.GetComponent<ShapeMovement>().Attacked();

                            if (targetedEnemy.GetComponent<ShapeMovement>().Health <= 0)
                            {
                                GameObject.Find("WaveManager").GetComponent<Gui>().TokenInt += targetedEnemy.GetComponent<ShapeMovement>().MaxHealth;
                            }
                            else
                            {
                                if (targetedEnemy.GetComponent<ShapeMovement>().IsStunned == false)
                                {
                                    StartCoroutine(Electrify());
                                }
                                else
                                {
                                    Destroy(gameObject);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (OwningTower.GetComponent<Tower>().Name == "SplitShot")
                {
                    OwningTower.GetComponent<Tower>().MultiReady = false;
                }
                OwningTower.GetComponent<Tower>().ReBullet();
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Electrify()
    {
        targetedEnemy.GetComponent<ShapeMovement>().IsStunned = true;
        targetedEnemy.GetComponent<ShapeMovement>().Speed = 0;
        Sprite.enabled = false;

        yield return new WaitForSeconds(StunTime);

        if (targetedEnemy != null)
        {
            if (targetedEnemy.GetComponent<ShapeMovement>().Health > 0)
            {
                targetedEnemy.GetComponent<ShapeMovement>().Speed = targetedEnemy.GetComponent<ShapeMovement>().MaxSpeed;
                targetedEnemy.GetComponent<ShapeMovement>().IsStunned = false;
            }
           
        }
        Destroy(gameObject);
    }
}
