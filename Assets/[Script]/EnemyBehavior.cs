using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    float _speedVertical, _speedHorizontal;

    [SerializeField]
    Boundry _verticalBoundry;

    [SerializeField]
    Boundry _horizontalBoundry;

    // Start is called before the first frame update
    void Start()
    {
       

        ResetEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (Mathf.PingPong(Time.time * _speedHorizontal, _horizontalBoundry.yPoint - _horizontalBoundry.xPoint)  
            + _horizontalBoundry.xPoint , transform.position.y - _speedVertical * Time.deltaTime, 0);



        if(_verticalBoundry.yPoint > transform.position.y)
        {
            ResetEnemy();


        }
    }

    void ResetEnemy()
    {
        _speedVertical = Random.Range(1, 4);
        _speedHorizontal = Random.Range(3, 7);

        transform.position = new Vector3(Random.Range(_horizontalBoundry.xPoint, _horizontalBoundry.yPoint), _verticalBoundry.xPoint, transform.position.z);
    }
}
