# GF-FsmSystem

GameFramework框架状态机系统

[EnglishDoc](README.md)

## 第一件事情

在你做你想做的事情之前，前瞧瞧 [GameFramework](https://github.com/EllanJiang/GameFramework) 这个仓库。

感谢E大 [EllanJiang](https://github.com/EllanJiang)。

## 安装

### 通过Git链接安装

安装需要支持PackageManager的Unity版本 (Unity >= 2019.3.4f1, Unity >= 2020.1a21). 

然后在unity中依次打开 Window -> Package Manager -> Add package from git URL

1. 该模块需要核心模块的支持，粘贴`https://github.com/shaun-he/GF-Core.git`，然后点击Add，并等待编译完成

2. 下载事件模块，粘贴 `https://github.com/shaun-he/GF-FsmSystem.git` ，点击Add添加，等待编译完成即可

### 通过本地安装

1. 到该链接`https://github.com/shaun-he/GF-Core.git`，点击页面绿色的按钮，然后点击**Download Zip**下载

2. 到该链接`https://github.com/shaun-he/GF-FsmSystem.git`，点击页面绿色的按钮，然后点击**Download Zip**下载

3. 解压两个压缩包，地方随意

4. 然后在Unity中依次打开 Window -> Package Manager -> Add package from disk

5. 在弹出窗口中找到解压的核心模块文件夹里的 **package.json**，等待编译完成

6. 再次点击**Add package from disk**，找到解压的事件模块文件夹里的**package.json**，等待编译完成即可

### 关于报错

如果在添加事件模块出现一堆报错，则是没有安装核心模块。

在安装核心模块后依然提示报错的话请找到事件模块的 **GF.FsmSystem.asmdef** 进行添加核心模块依赖。

![https://z3.ax1x.com/2021/06/19/RiCl3q.png](https://z3.ax1x.com/2021/06/19/RiCl3q.png)

## 使用

TODO...
