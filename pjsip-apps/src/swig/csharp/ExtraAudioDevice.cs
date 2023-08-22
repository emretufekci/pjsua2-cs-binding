//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ExtraAudioDevice : AudioMedia {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ExtraAudioDevice(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.ExtraAudioDevice_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ExtraAudioDevice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ExtraAudioDevice obj) {
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

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_ExtraAudioDevice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ExtraAudioDevice(int playdev, int recdev) : this(pjsua2PINVOKE.new_ExtraAudioDevice(playdev, recdev), true) {
  }

  public void open() {
    pjsua2PINVOKE.ExtraAudioDevice_open(swigCPtr);
  }

  public void close() {
    pjsua2PINVOKE.ExtraAudioDevice_close(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isOpened() {
    bool ret = pjsua2PINVOKE.ExtraAudioDevice_isOpened(swigCPtr);
    return ret;
  }

}
