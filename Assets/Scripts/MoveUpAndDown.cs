using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{

    private float HeightVariance = 1f;
   

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * HeightVariance;//rong duy chuyen len xuong
    }
}
