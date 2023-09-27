using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePowers : MonoBehaviour
{
    public string PowerName;
    public GameObject DiamondPrefab;
    public bool dead = false;
    private string CurrentPower;
    // Start is called before the first frame update
    void Start()
    {
        CurrentPower = PowerName;
        if (CurrentPower == "Heal")
        {
            StartCoroutine(Heal());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            var NewShape = Instantiate(DiamondPrefab, gameObject.transform.position, gameObject.transform.rotation);
            NewShape.transform.parent = GameObject.Find("Shapes").transform;
            NewShape.GetComponent<ShapeMovement>().ShapeWaypoints = gameObject.GetComponent<ShapeMovement>().ShapeWaypoints;
            NewShape.GetComponent<ShapeMovement>().CurrentWaypointIndex = gameObject.GetComponent<ShapeMovement>().CurrentWaypointIndex;

            Destroy(gameObject);
        }
    }

    IEnumerator Heal()
    {
        gameObject.GetComponent<ShapeMovement>().Health += 2;

        yield return new WaitForSeconds(2f);
        StartCoroutine(Heal());
    }
}
