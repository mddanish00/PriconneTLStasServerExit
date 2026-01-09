/*
    PriconneTLStasServerExit is a BepInEx plugin to automatically close StasServer when closing Priconne.
    Copyright (C) 2026  mddanishh00
    Copyright (C) 2023  Kevga

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.

    This plugin is based on SugoiExitPatch from PriconneTLFixup (https://github.com/Kevga/PriconneTLFixup).
*/
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BepInEx.Logging;

namespace StasServerExit;

public class Log
{
    internal static ManualLogSource? BieLogger;

#if DEBUG
    private static void LogFactory(string message, LogLevel logLevel, string filePath, string member, int line)
    {
        var pathParts = filePath.Split('\\');
        var className = pathParts[^1].Replace(".cs", "");
        var caller = new StackFrame(3, true).GetMethod()?.Name;
        var prefix = $"[{caller}->{className}.{member}:{line}]: ";
        BieLogger?.Log(logLevel, $"{prefix}{message}");
    }

    public static void Debug(string message, [CallerFilePath] string filePath = "",
        [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
    {
        LogFactory(message, LogLevel.Debug, filePath, member, line);
    }

    public static void Info(string message, [CallerFilePath] string filePath = "",
        [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
    {
        LogFactory(message, LogLevel.Info, filePath, member, line);
    }

    public static void Warn(string message, [CallerFilePath] string filePath = "",
        [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
    {
        LogFactory(message, LogLevel.Warning, filePath, member, line);
    }

    public static void Error(string message, [CallerFilePath] string filePath = "",
        [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
    {
        LogFactory(message, LogLevel.Error, filePath, member, line);
    }
#else
    private static void LogFactory(string message, LogLevel logLevel)
    {
        BieLogger?.Log(logLevel, message);
    }

    public static void Debug(string message, bool evenInReleaseBuild)
    {
        LogFactory(message, LogLevel.Debug);
    }

    public static void Info(string message)
    {
        LogFactory(message, LogLevel.Info);
    }

    public static void Warn(string message)
    {
        LogFactory(message, LogLevel.Warning);
    }

    public static void Error(string message)
    {
        LogFactory(message, LogLevel.Error);
    }
#endif
    [Conditional("DEBUG")]
    public static void Debug(Exception exception)
    {
        BieLogger?.Log(LogLevel.Debug, exception);
    }

    [Conditional("DEBUG")]
    public static void Debug(string message)
    {
        BieLogger?.Log(LogLevel.Debug, message);
    }

    public static void Info(Exception exception)
    {
        BieLogger?.Log(LogLevel.Info, exception);
    }

    public static void Warn(Exception exception)
    {
        BieLogger?.Log(LogLevel.Warning, exception);
    }

    public static void Error(Exception exception)
    {
        BieLogger?.Log(LogLevel.Error, exception);
    }
}