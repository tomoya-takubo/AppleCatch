using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float dropSpeed = -0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //　落下
        transform.Translate(0, this.dropSpeed, 0);

        //　一定の高さまで落ちたら消滅
        if(transform.position.y < -1)
        {
            Destroy(gameObject);
        }
    }
}
