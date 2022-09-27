using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Соединить тут объект которого камера должна преследовать.
    [SerializeField] private Transform _target;
    

    // Дистанция между объекта и самой камеры.
    [SerializeField] private Vector3 _offset = new Vector3(0, -10, 0);

    // Насколько плавно камера будет следовать за объектом.
    [SerializeField]
    private float _smooth = .1f;

  // Methods

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.transform.position + _offset, _smooth);
    }
}

