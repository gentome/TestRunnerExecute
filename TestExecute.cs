using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

public class TestExecute
{
    

    [MenuItem("Window/PlayModeTest")]
    public static void PlaymodeExecute()
    {
        var api = ScriptableObject.CreateInstance<TestRunnerApi>();
        var filter = new Filter()
        {
            testMode = TestMode.PlayMode
        };
        api.Execute(new ExecutionSettings(filter));
        
    }
    [MenuItem("Window/EditModeTest")]
    public static void EditmodeExecute()
    {
        var api = ScriptableObject.CreateInstance<TestRunnerApi>();
        var filter = new Filter()
        {
            testMode = TestMode.EditMode
        };
        api.Execute(new ExecutionSettings(filter));
        
    }
}
