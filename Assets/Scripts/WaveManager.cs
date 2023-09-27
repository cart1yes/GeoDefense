using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [Header("ShapeSpawning")]
    public int Wave;
    public string WaveState;
    public GameObject startPos;
    public GameObject startPos1;
    public GameObject startPos2;
    public GameObject startPos3;
    public bool DoneSpawning = false;
    public bool DoneGame = false;

    public GameObject ShapesFolder;

    [Header("ShapePrefabs")]
    public int shapeCount;
    public GameObject CubePrefab;
    public GameObject CirclePrefab;
    public GameObject TrianglePrefab;
    public GameObject StrongCubePrefab;
    public GameObject CrackedCubePrefab;
    public GameObject DiamondPrefab;
    public GameObject EnragedCubePrefab;
    public GameObject PentagonPrefab;
    public GameObject HeartPrefab;
    public GameObject HexagonPrefab;
    public GameObject OctagonPrefab;
    public GameObject SpikedCubePrefab;
    public GameObject SpikedCirclePrefab;
    public GameObject SPikedOctagonPrefab;
    public GameObject WeakStarPrefab;
    public GameObject StarPrefab;
    public GameObject SuperStarPrefab;

    [Header("Info")]
    public int PathAmt;
    [SerializeField] public List<Transform> waypointSet1;
    [SerializeField] public List<Transform> waypointSet2;
    [SerializeField] public List<Transform> waypointSet3;
    [SerializeField] public List<Transform> waypointSet4;

    // Start is called before the first frame update
    void Start()
    {
        Wave = 1;
        WaveState = "Waiting";
    }

    // Update is called once per frame
    void Update()
    {
        //shapeCount = ShapesFolder.GetComponent<SetActive>;

        if (shapeCount == 0 && DoneSpawning == true && GameObject.Find("WaveManager").GetComponent<Gui>().gameOver == false && DoneGame == false)
        {
            DoneSpawning = false;
            Wave++;
            GameObject.Find("WaveManager").GetComponent<Gui>().TokenInt += 50 * Wave - 50;
            GameObject.Find("WaveManager").GetComponent<Gui>().StartRound.gameObject.SetActive(true);
            GameObject.Find("WaveManager").GetComponent<Gui>().NormalSpeed1.gameObject.SetActive(false);
            GameObject.Find("WaveManager").GetComponent<Gui>().NormalSpeed2.gameObject.SetActive(false);
            WaveState = "Waiting";
        }

        if (WaveState == "Start")
        {
            WaveState = "Playing";
            StartCoroutine(Waves());
        }
    }
    IEnumerator Waves()
    {
        yield return new WaitForSeconds(1);
        if (Wave == 1)
        {
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CubePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
            //DoneGame = true;
        }
        else if (Wave == 2)
        {
            for (int i = 0; i < 7; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 3)
        {
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CubePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 4)
        {
            for (int i = 0; i < 7; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CubePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CirclePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 5)
        {
            for (int i = 0; i < 12; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CubePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 12; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CirclePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
            //DoneGame = true;
        }
        else if (Wave == 6)
        {
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(TrianglePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CirclePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 8; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CubePrefab, startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 7)
        {
            for (int i = 0; i < 12; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(TrianglePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            } 
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CirclePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 8)
        {
            for (int i = 0; i < 18; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CirclePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 12; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(TrianglePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 9)
        {
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CirclePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 20; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(TrianglePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 10)
        {
            for (int i = 0; i < 1; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(StrongCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 11)
        {
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(TrianglePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 2; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CrackedCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 12)
        {
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(TrianglePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 4; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CrackedCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 1; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HeartPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 13)
        {
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CrackedCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 2; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HeartPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 14)
        {
 
            for (int i = 0; i < 7; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CrackedCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 3; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HeartPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 2; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(PentagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 15)
        {
 
            for (int i = 0; i < 8; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(CrackedCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HeartPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 3; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(PentagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 16)
        {
 
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HeartPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 4; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(PentagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HeartPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 1; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HexagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 17)
        {
 
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HeartPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 7; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(PentagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HexagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        if (selectedPath == 1)
                        {
                            shapeMovement.ShapeWaypoints = waypointSet1;
                        }
                        else if (selectedPath == 2)
                        {
                            shapeMovement.ShapeWaypoints = waypointSet2;
                        }
                        else if (selectedPath == 3)
                        {
                            shapeMovement.ShapeWaypoints = waypointSet3;
                        }
                        else if (selectedPath == 4)
                        {
                            shapeMovement.ShapeWaypoints = waypointSet4;
                        }
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 1; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(OctagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 18)
        {
 
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(PentagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 7; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HexagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 3; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(OctagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 19)
        {
 
            for (int i = 0; i < 11; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(HexagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 6; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(OctagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 20)
        {
 
            for (int i = 0; i < 8; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SpikedCirclePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SpikedCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 1; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SPikedOctagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 21)
        {
 
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SpikedCirclePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SpikedCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 6; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SPikedOctagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 22)
        {
 
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SpikedCirclePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 10; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SpikedCubePrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 8; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SPikedOctagonPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
            for (int i = 0; i < 3; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(WeakStarPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 23)
        {
 
            for (int i = 0; i < 7; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(WeakStarPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 24)
        {
 
            for (int i = 0; i < 5; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(WeakStarPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            for (int i = 0; i < 4; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(StarPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
        }
        else if (Wave == 25)
        {
 
            for (int i = 0; i < 6; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(StarPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            yield return new WaitForSeconds(2);
            for (int i = 0; i < 1; i++)
            {
                var selectedPath = Random.Range(1, PathAmt);
                var startingPos = startPos;
                if (selectedPath == 1)
                {
                    startingPos = startPos;
                }
                else if (selectedPath == 2)
                {
                    startingPos = startPos1;
                }
                else if (selectedPath == 3)
                {
                    startingPos = startPos2;
                }
                else if (selectedPath == 4)
                {
                    startingPos = startPos3;
                }

                var NewShape = Instantiate(SuperStarPrefab,  startingPos.transform.position, transform.rotation);
                ShapeMovement shapeMovement = NewShape.GetComponent<ShapeMovement>();
                if (shapeMovement != null)
                {
                    if (selectedPath == 1)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet1;
                    }
                    else if (selectedPath == 2)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet2;
                    }
                    else if (selectedPath == 3)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet3;
                    }
                    else if (selectedPath == 4)
                    {
                        shapeMovement.ShapeWaypoints = waypointSet4;
                    }
                }
                NewShape.transform.parent = ShapesFolder.transform;
                shapeCount += 1;
                yield return new WaitForSeconds(0.75f);
            }
            DoneSpawning = true;
            DoneGame = true;
        }
    }
}