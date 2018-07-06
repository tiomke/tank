using UnityEngine;
using System.Collections;
using FairyGUI;
using System.Collections.Generic;
using DesignData;

// 设置界面
public class UISettings
{
    
    public UISettings(TanksMP.UIMain main)
    {
        // 创建界面并添加到 GRoot 显示
        var view = UIPackage.CreateObject("LoadingUI", "Settings").asCom;
        GRoot.inst.AddChild(view);

        // 取出控件
        var name = view.GetChild("TxtName").asTextField;
        var select = view.GetChild("Select").asComboBox;
        var chkMusic = view.GetChild("ChkMusic").asButton;
        var sldMusic = view.GetChild("SliderMusic").asSlider;
        var chkRecord = view.GetChild("ChkRecord").asButton;
        var btnClose = view.GetChild("BtnClose").asButton;

        // 初始化
        name.text = main.nameField.text;
        var v = main.networkDrop.value;
        select.text = v == 0 ? "联网": v==1 ? "局域网":"本地";
        chkMusic.GetController("button").selectedIndex = main.musicToggle.isOn ? 0:1;
        sldMusic.value = main.volumeSlider.value;
        chkRecord.GetController("button").selectedIndex = main.recordToggle.isOn ? 0 : 1;

        btnClose.onClick.Set(() =>
        {
            // 把参数都记录到玩家
            main.nameField.text = name.text;
            int tmp = 0;
            switch (select.text)
            {
                case "联网":
                    tmp = 0;
                    break;
                case "局域网":
                    tmp = 1;
                    break;
                case "本地":
                    tmp = 2;
                    break;
            }
            main.networkDrop.value = tmp;
            main.musicToggle.isOn = chkMusic.GetController("button").selectedIndex == 0;
            main.recordToggle.isOn = chkRecord.GetController("button").selectedIndex == 0;
            main.volumeSlider.value = (float)sldMusic.value;
            main.CloseSettings();
            view.visible = false;
        });       


    }
}
