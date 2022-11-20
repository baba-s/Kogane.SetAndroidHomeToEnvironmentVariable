using System;
using UnityEditor.Android;

namespace Kogane
{
    /// <summary>
    /// ANDROID_HOME を環境変数に設定するクラス
    /// </summary>
    public static class SetAndroidHomeToEnvironmentVariable
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 設定します
        /// </summary>
        public static void Set( EnvironmentVariableTarget target )
        {
            SetEnvironmentVariableAndroidHome( target );
            SetEnvironmentVariablePath( target );
        }

        /// <summary>
        /// ANDROID_HOME を設定します
        /// </summary>
        private static void SetEnvironmentVariableAndroidHome( EnvironmentVariableTarget target )
        {
            Environment.SetEnvironmentVariable
            (
                variable: "ANDROID_HOME",
                value: AndroidExternalToolsSettings.sdkRootPath,
                target: target
            );
        }

        /// <summary>
        /// PATH に $ANDROID_HOME/tools と $ANDROID_HOME/platform-tools を設定します
        /// </summary>
        private static void SetEnvironmentVariablePath( EnvironmentVariableTarget target )
        {
            var oldPath = Environment.GetEnvironmentVariable
            (
                variable: "PATH",
                target: target
            );

            var newPath = $@"{oldPath}:$ANDROID_HOME/tools:$ANDROID_HOME/platform-tools";

            Environment.SetEnvironmentVariable
            (
                variable: "PATH",
                value: newPath,
                target: target
            );
        }
    }
}