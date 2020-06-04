using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilizationOfSOScript : MonoBehaviour
{
    [SerializeField] private ScriptableObjectClass myScriptableObj;
    List<Light> lights;
    // Start is called before the first frame update
    void Start()
    {
        lights = new List<Light>();
        foreach(Vector3 spawn in myScriptableObj.spawnPoints)
        {
            GameObject myLight = new GameObject("Light");
            myLight.AddComponent<Light>();
            myLight.transform.position = spawn;
            myLight.GetComponent<Light>().enabled = false;
            if(myScriptableObj.colorIsRandom)
            {
                myLight.GetComponent<Light>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            }
            else
            {
                myLight.GetComponent<Light>().color = myScriptableObj.objColor;
            }
            lights.Add(myLight.GetComponent<Light>());
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown("Fire1"))
        {
            foreach(Light light in lights)
            {
                light.enabled = !light.enabled;
            }
        }
        if (Input.GetKeyDown("Fire2"))
        {
            UpdateLights();
        }
    }
    void UpdateLights()
    {
        foreach (var myLight in lights)
        {
            myLight.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
