//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class JbufState : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JbufState(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JbufState obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(JbufState obj) {
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

  ~JbufState() {
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
          pjsua2PINVOKE.delete_JbufState(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint frameSize {
    set {
      pjsua2PINVOKE.JbufState_frameSize_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_frameSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint minPrefetch {
    set {
      pjsua2PINVOKE.JbufState_minPrefetch_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_minPrefetch_get(swigCPtr);
      return ret;
    } 
  }

  public uint maxPrefetch {
    set {
      pjsua2PINVOKE.JbufState_maxPrefetch_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_maxPrefetch_get(swigCPtr);
      return ret;
    } 
  }

  public uint burst {
    set {
      pjsua2PINVOKE.JbufState_burst_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_burst_get(swigCPtr);
      return ret;
    } 
  }

  public uint prefetch {
    set {
      pjsua2PINVOKE.JbufState_prefetch_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_prefetch_get(swigCPtr);
      return ret;
    } 
  }

  public uint size {
    set {
      pjsua2PINVOKE.JbufState_size_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_size_get(swigCPtr);
      return ret;
    } 
  }

  public uint avgDelayMsec {
    set {
      pjsua2PINVOKE.JbufState_avgDelayMsec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_avgDelayMsec_get(swigCPtr);
      return ret;
    } 
  }

  public uint minDelayMsec {
    set {
      pjsua2PINVOKE.JbufState_minDelayMsec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_minDelayMsec_get(swigCPtr);
      return ret;
    } 
  }

  public uint maxDelayMsec {
    set {
      pjsua2PINVOKE.JbufState_maxDelayMsec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_maxDelayMsec_get(swigCPtr);
      return ret;
    } 
  }

  public uint devDelayMsec {
    set {
      pjsua2PINVOKE.JbufState_devDelayMsec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_devDelayMsec_get(swigCPtr);
      return ret;
    } 
  }

  public uint avgBurst {
    set {
      pjsua2PINVOKE.JbufState_avgBurst_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_avgBurst_get(swigCPtr);
      return ret;
    } 
  }

  public uint lost {
    set {
      pjsua2PINVOKE.JbufState_lost_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_lost_get(swigCPtr);
      return ret;
    } 
  }

  public uint discard {
    set {
      pjsua2PINVOKE.JbufState_discard_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_discard_get(swigCPtr);
      return ret;
    } 
  }

  public uint empty {
    set {
      pjsua2PINVOKE.JbufState_empty_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.JbufState_empty_get(swigCPtr);
      return ret;
    } 
  }

  public JbufState() : this(pjsua2PINVOKE.new_JbufState(), true) {
  }

}
