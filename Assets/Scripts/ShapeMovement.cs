using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMovement : MonoBehaviour
{
    [Header("ShapeInfo")]
    public bool Alive = false;
    public float Speed;
    public float MaxSpeed;
    public int Health;
    public int MaxHealth;
    public string Name;
    public GameObject StunIcon;
    public GameObject HitIcon;
    public bool IsStunned = false;
    public int CurrentWaypointIndex;
    public ShapePowers ShapePowers;

    [SerializeField] public List<Transform> ShapeWaypoints;
    

    // Start is called before the first frame update
    void Awake()
    {
        HitIcon.SetActive(false);
        StunIcon.SetActive(false);
        Alive = true;
        MaxHealth = Health;
        MaxSpeed = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentWaypointIndex < ShapeWaypoints.Count)
        {
            Transform CurrentWaypoint = ShapeWaypoints[CurrentWaypointIndex];
            transform.position = Vector2.MoveTowards(transform.position, CurrentWaypoint.position, Speed * Time.deltaTime);

            if (transform.position == CurrentWaypoint.position)
            {
                CurrentWaypointIndex++;
            }
        }
        else
        {
            GameObject.Find("WaveManager").GetComponent<WaveManager>().shapeCount -= 1;
            GameObject.Find("WaveManager").GetComponent<Gui>().LifeInt -= Health;
            //print(Health);
            Destroy(gameObject);
        }

        if (IsStunned == true)
        {
            StunIcon.SetActive(true);
        }
        else
        {
            StunIcon.SetActive(false);
        }

        if(Health <= 0)
        {
            if (ShapePowers == null)
            {
                GameObject.Find("WaveManager").GetComponent<WaveManager>().shapeCount -= 1;
                Destroy(gameObject);
            }
            else
            {
                if (ShapePowers.PowerName == "ShapeOnDeath")
                {
                    ShapePowers.dead = true;
                }
            }  
        }
    }

    public void Attacked()
    {
        StartCoroutine(DamageFeedback());
    }

    IEnumerator DamageFeedback()
    {
        HitIcon.SetActive(true);
        yield return new WaitForSeconds(0.03f);
        HitIcon.SetActive(false);
    }
}
