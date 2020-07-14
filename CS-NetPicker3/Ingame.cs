using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICities;
using UnityEngine;

namespace CS_NetPicker3
{
    public class IngameLoader : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);

            if (NetPickerTool.instance == null)
            {
                ToolController toolController = ToolsModifierControl.toolController;
                NetPickerTool.instance = toolController.gameObject.AddComponent<NetPickerTool>();
                NetPickerTool.instance.enabled = false;
            }
        }

        public override void OnReleased()
        {
            base.OnReleased();
            GameObject.Destroy(NetPickerTool.instance);
        }

        public override void OnLevelUnloading()
        {
            base.OnLevelUnloading();
            GameObject.Destroy(NetPickerTool.instance);
        }

        public override void OnCreated(ILoading loading)
        {
            base.OnCreated(loading);
            if (LoadingManager.instance.m_loadingComplete)
            {
                if (NetPickerTool.instance == null)
                {
                    ToolController toolController = ToolsModifierControl.toolController;
                    NetPickerTool.instance = toolController.gameObject.AddComponent<NetPickerTool>();
                    NetPickerTool.instance.enabled = false;
                }
            }
        }
    }

    public class IngameKeybindingResolver : ThreadingExtensionBase
    {
        public override void OnUpdate(float realTimeDelta, float simulationTimeDelta)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                Debug.Log("N key");
                NetPickerTool.instance.enabled = !NetPickerTool.instance.enabled;
                ToolsModifierControl.SetTool<NetPickerTool>();
            }
        }
    }
}
