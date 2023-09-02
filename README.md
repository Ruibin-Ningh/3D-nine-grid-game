# 3D九宫格游戏
这是一个3D的九宫格游戏，引擎为Unity。This is a 3D nine grid game, engine Unity.
玩家可以使用**WASD**来进行'方块'的移动，如图1
_图1：_![image](https://github.com/Ruibin-Ningh/3D-nine-grid-game/assets/132149419/afd5e749-bdd4-4aa1-9266-2a0e48ffffd2)_中间的正方体为玩家_
### 游戏规则
玩家在九宫格内移动，每操控正方体移动的距离是**1格**。
玩家在吃掉球为**获胜**，随后进入**下一关**
除了第一关，其他关均是**随机生成位置**，**不存在生成在玩家的位置上。**
# 代码展示
本项目只有唯一一个C#脚本，具体代码呈现：
# 3D九宫格游戏
这是一个3D的九宫格游戏，引擎为Unity。This is a 3D nine grid game, engine Unity.
玩家可以使用**WASD**来进行'方块'的移动，如图1
_图1：_![image](https://github.com/Ruibin-Ningh/3D-nine-grid-game/assets/132149419/afd5e749-bdd4-4aa1-9266-2a0e48ffffd2)_中间的正方体为玩家_
### 游戏规则
玩家在九宫格内移动，每操控正方体移动的距离是**1格**。
玩家在吃掉球为**获胜**，随后进入**下一关**
除了第一关，其他关均是**随机生成位置**，**不存在生成在玩家的位置上。**
# 代码展示
本项目只有唯一一个C#脚本，具体代码呈现：
```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Play : MonoBehaviour
{
    public GameObject Game;
    public void OnAnimatorMove()
    {
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
        Debug.Log("随机结果:");
        Debug.Log(randomInt1);
        Debug.Log(randomInt2);
        z = -2.4f + (randomInt1 * 1.2f);
        x = -2.4f + (randomInt2 * 1.2f);
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
        print("开始");
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
```
