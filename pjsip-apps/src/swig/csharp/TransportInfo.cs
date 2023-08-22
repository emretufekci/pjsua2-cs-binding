//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TransportInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TransportInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TransportInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TransportInfo obj) {
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

  ~TransportInfo() {
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
          pjsua2PINVOKE.delete_TransportInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int id {
    set {
      pjsua2PINVOKE.TransportInfo_id_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.TransportInfo_id_get(swigCPtr);
      return ret;
    } 
  }

  public pjsip_transport_type_e type {
    set {
      pjsua2PINVOKE.TransportInfo_type_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_transport_type_e ret = (pjsip_transport_type_e)pjsua2PINVOKE.TransportInfo_type_get(swigCPtr);
      return ret;
    } 
  }

  public string typeName {
    set {
      pjsua2PINVOKE.TransportInfo_typeName_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TransportInfo_typeName_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string info {
    set {
      pjsua2PINVOKE.TransportInfo_info_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TransportInfo_info_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint flags {
    set {
      pjsua2PINVOKE.TransportInfo_flags_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.TransportInfo_flags_get(swigCPtr);
      return ret;
    } 
  }

  public string localAddress {
    set {
      pjsua2PINVOKE.TransportInfo_localAddress_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TransportInfo_localAddress_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string localName {
    set {
      pjsua2PINVOKE.TransportInfo_localName_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TransportInfo_localName_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint usageCount {
    set {
      pjsua2PINVOKE.TransportInfo_usageCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.TransportInfo_usageCount_get(swigCPtr);
      return ret;
    } 
  }

  public TransportInfo() : this(pjsua2PINVOKE.new_TransportInfo(), true) {
  }

}
