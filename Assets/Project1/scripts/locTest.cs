using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locTest : MonoBehaviour
{
    public List<Transform> locs;
    public GameObject powerup;
    // Start is called before the first frame update
    void Start()
    {
        var loc_load = GameObject.FindGameObjectsWithTag("loc");


        for (int i = 0; i < loc_load.Length; i++)
        {
            locs.Add(loc_load[i].transform);
        }

        var loc_place = locs[Random.Range(0, locs.Count)];
        Instantiate(powerup, loc_place.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
