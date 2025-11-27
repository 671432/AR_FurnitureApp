using Lean.Common;
using UnityEngine;

public class BoundingBoxScript : MonoBehaviour
{

    public GameObject boundingBox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<LeanSelectable>().IsSelected == true)
        {
            boundingBox.SetActive(true);
        }
        else
        {
            boundingBox.SetActive(false);
        }
    }
}
