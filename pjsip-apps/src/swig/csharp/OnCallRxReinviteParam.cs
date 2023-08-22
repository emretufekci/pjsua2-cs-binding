//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class OnCallRxReinviteParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnCallRxReinviteParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnCallRxReinviteParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(OnCallRxReinviteParam obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~OnCallRxReinviteParam() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_OnCallRxReinviteParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SdpSession offer {
    set {
      pjsua2PINVOKE.OnCallRxReinviteParam_offer_set(swigCPtr, SdpSession.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCallRxReinviteParam_offer_get(swigCPtr);
      SdpSession ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdpSession(cPtr, false);
      return ret;
    } 
  }

  public SipRxData rdata {
    set {
      pjsua2PINVOKE.OnCallRxReinviteParam_rdata_set(swigCPtr, SipRxData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCallRxReinviteParam_rdata_get(swigCPtr);
      SipRxData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipRxData(cPtr, false);
      return ret;
    } 
  }

  public bool isAsync {
    set {
      pjsua2PINVOKE.OnCallRxReinviteParam_isAsync_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.OnCallRxReinviteParam_isAsync_get(swigCPtr);
      return ret;
    } 
  }

  public pjsip_status_code statusCode {
    set {
      pjsua2PINVOKE.OnCallRxReinviteParam_statusCode_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_status_code ret = (pjsip_status_code)pjsua2PINVOKE.OnCallRxReinviteParam_statusCode_get(swigCPtr);
      return ret;
    } 
  }

  public CallSetting opt {
    set {
      pjsua2PINVOKE.OnCallRxReinviteParam_opt_set(swigCPtr, CallSetting.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCallRxReinviteParam_opt_get(swigCPtr);
      CallSetting ret = (cPtr == global::System.IntPtr.Zero) ? null : new CallSetting(cPtr, false);
      return ret;
    } 
  }

  public OnCallRxReinviteParam() : this(pjsua2PINVOKE.new_OnCallRxReinviteParam(), true) {
  }

}