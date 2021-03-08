using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public MeshRenderer mR;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.rotation.eulerAngles);
        mR.material.SetFloat("_Size", Random.Range(10, 50));
        mR.material.SetColor("_Color1", Color.HSVToRGB(Random.value, 1, 1));
        mR.material.SetColor("_Color2", Color.HSVToRGB(Random.value, 1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 1, transform.rotation.eulerAngles.z);
    }



}