using UnityEngine;
using System.Collections;

public class CandyGenerator : MonoBehaviour {

    public GameObject cookie;

	// Use this for initialization
	void Start () {
        GameObject ground = GameObject.FindWithTag("Ground");
        Debug.Log(ground.ToString());
        Transform rt = ground.transform;
        Debug.Log(rt.ToString());
        Debug.Log(ground.GetComponent<Renderer>().bounds.size.x);
        Debug.Log(ground.GetComponent<Renderer>().bounds.size.z);

        for (int i = 0; i < 50000; i++)
        {

                float xVal = Random.Range(0, ground.GetComponent<Renderer>().bounds.size.x) /100;
                float zVal = Random.Range(0, ground.GetComponent<Renderer>().bounds.size.z) /100;

                Instantiate(cookie, new Vector3(xVal, 2, zVal), Quaternion.Euler(270f, 0f, 0f));
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bird")
        {
            Destroy(col.gameObject);
        }
    }
}
