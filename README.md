# tank
一个十分基本的多人游戏的项目框架。

基于 Unity 2018.1.6f1（个人免费版） + FairyGUI 3.8.2（开源） + Tanks Multiplayer 1.2.2（商业闭源），并使用了 C# 库 CsvHelper 2.16.3（开源） 。


## 简介
本 repo 主要思想是项目中不同分工的人可以专注于自己的事务。并且减少每种分工的工作量。

多人联网用的 Tanks Multiplayer 提供的基于 UNet 的框架，Tanks Multiplayer 提供了一些简单的怪物 AI，相机跟随，玩家、道具生成，输入控制等功能。
本 repo 是在 Tanks Multiplayer 基础上更改的， Tanks Multiplayer 的文档见 "./Proj/Assets" 中 TanksMultiplayer.pdf 文件。 UNet 相关参考链接[在这里](https://docs.unity3d.com/Manual/UNet.html)。

## 工作流程
策划在 DesignData 中的 xlsx 文件里填表后，程序运行 Tools 中的 xlsx2csv.py 将策划表转成 Unity 项目（Proj 目录） Resources/Data 中的 csv 文件。
美术在 FairyGUI-Editor 中编辑界面后，将界面导出到 Resources/FairyGUI 目录。
程序进行 Unity 项目的开发工作。

## 项目结构

>DesignData/  
Docs/  
FairyGUI/  
Proj/  
Tools/  

DesignData 用于存放策划表。
Docs 可以用于存放策划文案之类的文档。
FairyGUI 存放有用于编辑界面的 FairyGUI-Editor 和 FairyGUI 项目目录 Assets。Assets 中包含界面相关的组件数据。
Proj 是一个 Unity 项目。
Tools 用于存放一些开发涉及的小工具，目前只有一个策划表转 csv 的工具。

## Refs

[FairyGUI 教程](http://www.fairygui.com/guide/)


