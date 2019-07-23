using System;

namespace BridgePattern
{
    public abstract class BaseInfo
    {
        //操作系统
        public abstract string System();

        //系统版本
        public abstract string Version();

        //玩游戏
        public abstract void Game();

        //看电影
        public abstract void Movie();
    }
}