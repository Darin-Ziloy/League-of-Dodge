using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ResapwnObject : MonoBehaviour
{

    public Transform Traget;
    public Collider[] coll;
    public float minX, minZ, minY; // край координат
    public float maxX, maxZ, maxY; // край координат
    public float minDist; // дистанция проверки на префабы вокруг
    public GameObject[] prefabs; // список префабов
    public Transform platform; // платформа
    public string prefab_tag; // тег для префабов

    public float PerSecond = 1f;
    


    public void Placement()
    {
        float x = Random.Range(minX, maxX) + platform.position.x; // позиция
        float z = Random.Range(minZ, maxZ) + platform.position.z;
        float y = Random.Range(minY, maxY) + platform.position.y;
        bool check;
        do
        {
            check = false; 
            coll = Physics.OverlapSphere(new Vector3(x, y, z), minDist); // берем список коллайдеров, которые есть вокруг точки
            foreach (Collider col in coll) // перебираем все найденные коллайдеры
                if (col.tag == prefab_tag) check = true; // если хоть один имеет тег префаба - проверка не пройдена
        }
        while (check); 
        Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(x, y, z), transform.rotation); // собственно, ставим сам префаб
    }


    
    
    public static bool scan = true; // есть или нет пепрсонаж с тегом на сцене
    public int reset = 0; // обнуление таймера
    public static float time; //таймер
    void Update()
        {
            time += Time.deltaTime; //таймер
            if (time >= PerSecond)
            { //если таймер досчитал до X или больше
              
                if (scan == true) //если объекта с тегом нет на сцене то 
                {
                    Placement();
                }
                time = reset; //обнулить таймер
            }

            this.transform.LookAt(Traget);
        }
    

}