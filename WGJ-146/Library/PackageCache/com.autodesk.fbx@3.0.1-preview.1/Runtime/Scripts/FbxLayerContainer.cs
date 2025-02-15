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

public class FbxLayerContainer : FbxNodeAttribute {
  internal FbxLayerContainer(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxLayerContainer Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxLayerContainer_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxLayerContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerContainer(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxLayerContainer Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxLayerContainer_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxLayerContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerContainer(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public int CreateLayer() {
    int ret = NativeMethods.FbxLayerContainer_CreateLayer(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetLayerCount() {
    int ret = NativeMethods.FbxLayerContainer_GetLayerCount__SWIG_0(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetLayerCount(FbxLayerElement.EType pType, bool pUVCount) {
    int ret = NativeMethods.FbxLayerContainer_GetLayerCount__SWIG_1(swigCPtr, (int)pType, pUVCount);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetLayerCount(FbxLayerElement.EType pType) {
    int ret = NativeMethods.FbxLayerContainer_GetLayerCount__SWIG_2(swigCPtr, (int)pType);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayer GetLayer(int pIndex) {
    global::System.IntPtr cPtr = NativeMethods.FbxLayerContainer_GetLayer(swigCPtr, pIndex);
    FbxLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayer(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxLayerContainer other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxLayerContainer;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxLayerContainer).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxLayerContainer a, FbxLayerContainer b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxLayerContainer a, FbxLayerContainer b) {
    return !(a == b);
  }

}

}
