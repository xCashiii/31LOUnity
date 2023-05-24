using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformerteseter : MonoBehaviour
{
    public Transform transformToeReset;
    public Vector3 startingPosition;
    public Vector3 staringRotation;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transformToeReset;
        // staringRotation = transformToeReset.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
