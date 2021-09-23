# 2048
## 场景搭建
1. 主菜单界面

    游戏标题：2048
    
    按钮：开始游戏

        按钮：4X4 5X5 6X6 返回

    按钮：设置

        滑动模块：音乐 音效

        按钮：返回

    按钮：退出游戏

2. 游戏界面

    游玩界面：
    
        记录的数据：显示当前分数  显示最高分数

        按钮：撤销操作 重新开始 退出到主菜单

        格子：默认4X4

    胜利界面：

        按钮：再来一局 返回主菜单

    失败界面：

        按钮：再来一局 返回主菜单

3. 用到的函数和类

PlayerPrefs : a class that stores Player preferences between game sessions.

SceneManager.LoadSceneAsync() : 异步读取场景
