//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class pjmedia_tone_digit : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal pjmedia_tone_digit(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(pjmedia_tone_digit obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(pjmedia_tone_digit obj) {
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

  ~pjmedia_tone_digit() {
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
          pjsua2PINVOKE.delete_pjmedia_tone_digit(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public char digit {
    set {
      pjsua2PINVOKE.pjmedia_tone_digit_digit_set(swigCPtr, value);
    } 
    get {
      char ret = pjsua2PINVOKE.pjmedia_tone_digit_digit_get(swigCPtr);
      return ret;
    } 
  }

  public short on_msec {
    set {
      pjsua2PINVOKE.pjmedia_tone_digit_on_msec_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_digit_on_msec_get(swigCPtr);
      return ret;
    } 
  }

  public short off_msec {
    set {
      pjsua2PINVOKE.pjmedia_tone_digit_off_msec_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_digit_off_msec_get(swigCPtr);
      return ret;
    } 
  }

  public short volume {
    set {
      pjsua2PINVOKE.pjmedia_tone_digit_volume_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_digit_volume_get(swigCPtr);
      return ret;
    } 
  }

  public pjmedia_tone_digit() : this(pjsua2PINVOKE.new_pjmedia_tone_digit(), true) {
  }

}
