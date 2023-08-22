//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class OnStreamPreCreateParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnStreamPreCreateParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnStreamPreCreateParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(OnStreamPreCreateParam obj) {
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

  ~OnStreamPreCreateParam() {
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
          pjsua2PINVOKE.delete_OnStreamPreCreateParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint streamIdx {
    set {
      pjsua2PINVOKE.OnStreamPreCreateParam_streamIdx_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.OnStreamPreCreateParam_streamIdx_get(swigCPtr);
      return ret;
    } 
  }

  public StreamInfo streamInfo {
    set {
      pjsua2PINVOKE.OnStreamPreCreateParam_streamInfo_set(swigCPtr, StreamInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnStreamPreCreateParam_streamInfo_get(swigCPtr);
      StreamInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new StreamInfo(cPtr, false);
      return ret;
    } 
  }

  public OnStreamPreCreateParam() : this(pjsua2PINVOKE.new_OnStreamPreCreateParam(), true) {
  }

}
