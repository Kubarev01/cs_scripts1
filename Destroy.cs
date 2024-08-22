using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    // Уничтожаем этот объект при старте игры
    void Start()
    {
        
        Destroy(gameObject); // Уничтожает текущий игровой объект
    }


    void Update()
    {

    }
}
