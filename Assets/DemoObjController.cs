using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoObjController : MonoBehaviour
{
    public List<GameObject> dotsDests;
    private GameObject Dest;

    public float demoObjSpeed;
    public int curIndex;
    // Start is called before the first frame update
    void Start()
    {
        curIndex = 0;
        Dest = dotsDests[curIndex];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Dest.transform.position, Time.deltaTime * demoObjSpeed);
        transform.LookAt(Dest.transform);

        if (transform.position == Dest.transform.position)
        {
            if(curIndex != dotsDests.Count - 1)
            {
                curIndex += 1;
                Dest = dotsDests[curIndex];
            }
            else
            {
                curIndex = 0;
                Dest = dotsDests[curIndex];
            }
        }

    }
}
