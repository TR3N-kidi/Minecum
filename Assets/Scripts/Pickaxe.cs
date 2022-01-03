using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : MonoBehaviour
{
    [SerializeField] private float _speedRotaion = 3f;

    [SerializeField] private Vector3 _startingRotation = new Vector3(-180f, 180f, 0f);
    [SerializeField] private Vector3 _endRotation = new Vector3(-270f, 180f, 0f);

    private Vector3 _currentRotation = Vector3.zero;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _currentRotation = _endRotation;

            transform.rotation = Quaternion.Euler(_currentRotation);
            /*transform.localEulerAngles = _currentRotation;*/
        }
        if(Input.GetMouseButtonUp(0))
        {
            _currentRotation = _startingRotation;
            transform.rotation = Quaternion.Euler(_currentRotation);

            /*transform.localEulerAngles= _currentRotation;*/
        }



        /*transform.rotation = new Quaternion((float)_currentRotation.x, (float)_currentRotation.y, (float)_currentRotation.z, _speedRotaion);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    _currentRotation = _endRotation;
                    break;

                case TouchPhase.Ended:
                    _currentRotation = _startingRotation;
                    break;
            }
        */
    }
}
