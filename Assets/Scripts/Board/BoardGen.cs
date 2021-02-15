using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum BoardSize
{
    Normal,
    Large,
    Expansive,
    Other
}
public class BoardGen : MonoBehaviour
{
    [SerializeField]
    private BoardSize boardSize;
    
}
