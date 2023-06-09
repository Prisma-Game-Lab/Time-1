using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovementSO", menuName = "ScriptableObjects/Movement")]
public class MovementSO : ScriptableObject
{
    public float moveSpeed = 3.5f;
    public float runSpeed = 3.5f;
    public bool canMove = true;
    [HideInInspector] public Vector3 initialPosition;
    [HideInInspector] public bool redirect = false;

    private void OnEnable()
    {
        canMove = true;
    }
}
