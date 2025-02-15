//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxPropertyNullELook : FbxProperty {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxPropertyNullELook(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativeMethods.FbxPropertyNullELook_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPropertyNullELook obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxPropertyNullELook Set(FbxNull.ELook pValue) {
    FbxPropertyNullELook ret = new FbxPropertyNullELook(NativeMethods.FbxPropertyNullELook_Set(swigCPtr, (int)pValue), false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxNull.ELook Get() {
    FbxNull.ELook ret = (FbxNull.ELook)NativeMethods.FbxPropertyNullELook_Get(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxNull.ELook EvaluateValue(FbxTime pTime, bool pForceEval) {
    FbxNull.ELook ret = (FbxNull.ELook)NativeMethods.FbxPropertyNullELook_EvaluateValue__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), pForceEval);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxNull.ELook EvaluateValue(FbxTime pTime) {
    FbxNull.ELook ret = (FbxNull.ELook)NativeMethods.FbxPropertyNullELook_EvaluateValue__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxNull.ELook EvaluateValue() {
    FbxNull.ELook ret = (FbxNull.ELook)NativeMethods.FbxPropertyNullELook_EvaluateValue__SWIG_2(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
