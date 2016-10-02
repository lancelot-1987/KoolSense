// Decompiled with JetBrains decompiler
// Type: hpCasl.CommandPlugin
// Assembly: hpcasl, Version=3.5.1.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: 9AAD147B-68F0-4BCA-936C-55CC3A477BC4
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\hpcasl.dll

using System;
using System.Reflection;

namespace hpCasl
{
  internal abstract class CommandPlugin
  {
    public abstract Assembly PluginAssembly { get; }

    public abstract string[] SupportedGetCommands();

    public abstract enReturnCode TypeOfGet(string sCommandName, out Type typeOut);

    public abstract bool IsGetSupported(string sCommandName);

    public abstract enReturnCode Get(string sCommandName, out object oDataOut);

    public abstract string[] SupportedSetCommands();

    public abstract enReturnCode TypeOfSet(string sCommandName, out Type typeIn);

    public abstract bool IsSetSupported(string sCommandName);

    public abstract enReturnCode Set(string sCommandName, object oDataIn);

    public abstract string[] SupportedExecuteCommands();

    public abstract enReturnCode TypeOfExecute(string sCommandName, out Type tDataIn, out Type tDataOut);

    public abstract bool IsExecuteSupported(string sCommandName);

    public abstract enReturnCode Execute(string sCommandName, object oDataIn, out object oDataOut);
  }
}
