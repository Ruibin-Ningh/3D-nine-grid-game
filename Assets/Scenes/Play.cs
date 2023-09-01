using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Play : MonoBehaviour
{
    public GameObject Game;
    public void OnAnimatorMove()
    {
        //移动逻辑
        if (Input.GetKeyDown(KeyCode.W)&&transform.position.z < 1.2)
        {
            transform.Translate(Vector3.forward * 1.2f);
        }
        if (Input.GetKeyDown(KeyCode.S)&&transform.position.z > -1.2)
        {
            transform.Translate(Vector3.forward * -1.2f);
        }
        if (Input.GetKeyDown(KeyCode.A)&&transform.position.x > -1.2)
        {
            transform.Translate(Vector3.left * 1.2f);
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 1.2)
        {
            transform.Translate(Vector3.left * -1.2f);
        }
    }
    public void Win()
    {
        Game.SetActive(false);
    }
    public void Cq()
    {
        int randomInt1 = Random.Range(1,4);
        int randomInt2 = Random.Range(1,4);
        float x = 0f;
        float z = 0f;
        if (randomInt1 == 2) 
        { 
            z = 0f;
        }
        if (randomInt1 == 3)
        {
            z = -1.2f;
        }
        if (randomInt1 == 1) 
        {
            z = 1.2f;
        }
        if (randomInt2 == 1)
        {
            x = -1.2f;
        }
        if (randomInt2 == 2)
        {
            x = 0f;
        }
        if (randomInt2 == 3)
        {
            x = 1.2f;
        }
        Game.transform.position = new Vector3(x,0.85f,z); 
        if (Game.transform.position == transform.position)
        {
            Cq();
        }
        Game.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        print("初始化运行");
    }

    // Update is called once per frame
    void Update()
    {
        if(Game.transform.position == transform.position)
        {
            Debug.Log("Win!");
            Win();
            Cq();
        }
        OnAnimatorMove();
    }
}
