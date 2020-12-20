using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SistemGame : MonoBehaviour
{
    public static SistemGame instance;
    public int ID;
    public GameObject TempatSpawn;
    public GameObject[] KoleksiBuah;
    

    // Start is called before the first frame update
    private void Awake() // diakses sebelum start dan update
    {
        instance = this;
    }
    void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        GameObject Benda = Instantiate(KoleksiBuah[ID]);
        
        Benda.transform.SetParent(TempatSpawn.transform, false);
        //Benda.transform.localScale = new Vector3(37f, 37f, 37f);
    }
}
