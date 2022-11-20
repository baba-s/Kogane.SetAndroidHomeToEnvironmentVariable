# Kogane Set Android Home To Environment Variable

ANDROID_HOME を環境変数に設定するクラス

## 使用例

```cs
using System;
using Kogane;
using UnityEditor;

public static class Example
{
    [MenuItem( "Tools/Hoge" )]
    public static void Hoge()
    {
        SetAndroidHomeToEnvironmentVariable.Set( EnvironmentVariableTarget.Process );
    }
}
```