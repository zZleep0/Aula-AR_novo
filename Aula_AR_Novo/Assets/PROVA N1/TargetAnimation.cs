using UnityEngine;

public class TargetAnimation : MonoBehaviour
{
    public float forca = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, forca, 0);
        
    }
}
