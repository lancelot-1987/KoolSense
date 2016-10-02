// Decompiled with JetBrains decompiler
// Type: HPQWMIEXLib._ICaslEventContainerEvents_EventProvider
// Assembly: Interop.HPQWMIEXLib, Version=4.0.112.1, Culture=neutral, PublicKeyToken=9c6f83d5b7f3d097
// MVID: E296F39D-9128-4C42-8E9C-5979CDD45E80
// Assembly location: C:\Windows.old\Program Files (x86)\Hewlett-Packard\Shared\Interop.HPQWMIEXLib.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace HPQWMIEXLib
{
    internal sealed class _ICaslEventContainerEvents_EventProvider : _ICaslEventContainerEvents_Event, IDisposable
    {
        private IConnectionPointContainer m_ConnectionPointContainer;
        private ArrayList m_aEventSinkHelpers;
        private IConnectionPoint m_ConnectionPoint;

        public _ICaslEventContainerEvents_EventProvider([In] object obj0)
        {
            this.m_ConnectionPointContainer = (IConnectionPointContainer)obj0;
        }

        private void Init()
        {
            IConnectionPoint ppCP = (IConnectionPoint)null;
            Guid riid = new Guid(new byte[16]
            {
        (byte) 52,
        (byte) 106,
        (byte) 174,
        (byte) 152,
        (byte) 90,
        (byte) 133,
        (byte) 27,
        (byte) 75,
        (byte) 173,
        (byte) 242,
        (byte) 152,
        (byte) 76,
        (byte) 139,
        (byte) 249,
        (byte) 163,
        (byte) 23
            });
            this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
            this.m_ConnectionPoint = ppCP;
            this.m_aEventSinkHelpers = new ArrayList();
        }

        public void add_Callback([In] _ICaslEventContainerEvents_CallbackEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                    this.Init();
                _ICaslEventContainerEvents_SinkHelper eventsSinkHelper = new _ICaslEventContainerEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_CallbackDelegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_Callback([In] _ICaslEventContainerEvents_CallbackEventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                    return;
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                    return;
                do
                {
                    _ICaslEventContainerEvents_SinkHelper eventsSinkHelper = (_ICaslEventContainerEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (eventsSinkHelper.m_CallbackDelegate != null && ((eventsSinkHelper.m_CallbackDelegate.Equals((object)obj0) ? 1 : 0) & (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(eventsSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                        ++index;
                }
                while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void add_Callback2([In] _ICaslEventContainerEvents_Callback2EventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                    this.Init();
                _ICaslEventContainerEvents_SinkHelper eventsSinkHelper = new _ICaslEventContainerEvents_SinkHelper();
                int pdwCookie = 0;
                this.m_ConnectionPoint.Advise((object)eventsSinkHelper, out pdwCookie);
                eventsSinkHelper.m_dwCookie = pdwCookie;
                eventsSinkHelper.m_Callback2Delegate = obj0;
                this.m_aEventSinkHelpers.Add((object)eventsSinkHelper);
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }

        public void remove_Callback2([In] _ICaslEventContainerEvents_Callback2EventHandler obj0)
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_aEventSinkHelpers == null)
                    return;
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 >= count)
                    return;
                do
                {
                    _ICaslEventContainerEvents_SinkHelper eventsSinkHelper = (_ICaslEventContainerEvents_SinkHelper)this.m_aEventSinkHelpers[index];
                    if (eventsSinkHelper.m_Callback2Delegate != null && ((eventsSinkHelper.m_Callback2Delegate.Equals((object)obj0) ? 1 : 0) & (int)byte.MaxValue) != 0)
                    {
                        this.m_aEventSinkHelpers.RemoveAt(index);
                        this.m_ConnectionPoint.Unadvise(eventsSinkHelper.m_dwCookie);
                        if (count <= 1)
                        {
                            Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
                            this.m_ConnectionPoint = (IConnectionPoint)null;
                            this.m_aEventSinkHelpers = (ArrayList)null;
                            return;
                        }
                        goto label_10;
                    }
                    else
                        ++index;
                }
                while (index < count);
                goto label_11;
                label_10:
                return;
                label_11:;
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }
        ~_ICaslEventContainerEvents_EventProvider()
        {
            Monitor.Enter((object)this);
            try
            {
                if (this.m_ConnectionPoint == null)
                    return;
                int count = this.m_aEventSinkHelpers.Count;
                int index = 0;
                if (0 < count)
                {
                    do
                    {
                        this.m_ConnectionPoint.Unadvise(((_ICaslEventContainerEvents_SinkHelper)this.m_aEventSinkHelpers[index]).m_dwCookie);
                        ++index;
                    }
                    while (index < count);
                }
                Marshal.ReleaseComObject((object)this.m_ConnectionPoint);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Monitor.Exit((object)this);
            }
        }


        public void Dispose()
        {
            this.Dispose();
            GC.SuppressFinalize((object)this);
        }
    }
}
