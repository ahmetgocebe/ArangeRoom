using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFurniture : MonoBehaviour
{
    public Material furnMat;
    private void Start()
    {
        CreateFurn(new Vector3(2, 1, 0));
    }
    public void CreateFurn(Vector3 size)
    {
        GameObject furn = GameObject.CreatePrimitive(PrimitiveType.Cube);
        furn.transform.localScale = size;
        furn.GetComponent<Renderer>().material = furnMat;
       
        if (furn.TryGetComponent(out Collider collider) == false)
        {
            furn.AddComponent<Collider>();
        }

        furn.AddComponent<Furniture>();
    }
}
