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

public class FbxBlendShape : FbxDeformer {
  internal FbxBlendShape(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxBlendShape Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxBlendShape_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxBlendShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBlendShape(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxBlendShape Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxBlendShape_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxBlendShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBlendShape(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetGeometry(FbxGeometry pGeometry) {
    bool ret = NativeMethods.FbxBlendShape_SetGeometry(swigCPtr, FbxGeometry.getCPtr(pGeometry));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxGeometry GetGeometry() {
    global::System.IntPtr cPtr = NativeMethods.FbxBlendShape_GetGeometry(swigCPtr);
    FbxGeometry ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxGeometry(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AddBlendShapeChannel(FbxBlendShapeChannel pBlendShapeChannel) {
    bool ret = NativeMethods.FbxBlendShape_AddBlendShapeChannel(swigCPtr, FbxBlendShapeChannel.getCPtr(pBlendShapeChannel));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxBlendShapeChannel RemoveBlendShapeChannel(FbxBlendShapeChannel pBlendShapeChannel) {
    global::System.IntPtr cPtr = NativeMethods.FbxBlendShape_RemoveBlendShapeChannel(swigCPtr, FbxBlendShapeChannel.getCPtr(pBlendShapeChannel));
    FbxBlendShapeChannel ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBlendShapeChannel(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetBlendShapeChannelCount() {
    int ret = NativeMethods.FbxBlendShape_GetBlendShapeChannelCount(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxBlendShapeChannel GetBlendShapeChannel(int pIndex) {
    global::System.IntPtr cPtr = NativeMethods.FbxBlendShape_GetBlendShapeChannel(swigCPtr, pIndex);
    FbxBlendShapeChannel ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBlendShapeChannel(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxBlendShape other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxBlendShape;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxBlendShape).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxBlendShape a, FbxBlendShape b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxBlendShape a, FbxBlendShape b) {
    return !(a == b);
  }

}

}
