using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShots : MonoBehaviour
{
    public GameObject prefab;
    public GameObject Barrel;
    public float speed;
    private GameObject mBullet;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouse.z = 0;
            mBullet = Instantiate(prefab,Barrel.transform.position,Quaternion.identity);
            direction = (mouse - Barrel.transform.position);
            Destroy(mBullet,2);

        }

        if (mBullet != null)
        {
            mBullet.transform.position += direction * speed * Time.deltaTime;
        }
        
    }
}
