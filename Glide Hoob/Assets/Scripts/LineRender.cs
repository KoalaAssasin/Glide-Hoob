using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public TargetJoint2D tJ2D;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer.SetPosition(0, tJ2D.anchor);
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.useWorldSpace = false;

        lineRenderer.SetPosition(1, transform.InverseTransformPoint(tJ2D.target));
    }
}
