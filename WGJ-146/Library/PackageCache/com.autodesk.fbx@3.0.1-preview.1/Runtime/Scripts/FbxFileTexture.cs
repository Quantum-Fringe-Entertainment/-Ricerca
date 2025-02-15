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

public class FbxFileTexture : FbxTexture {
  internal FbxFileTexture(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxFileTexture Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxFileTexture_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxFileTexture ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxFileTexture(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxFileTexture Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxFileTexture_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxFileTexture ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxFileTexture(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyBool UseMaterial {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxFileTexture_UseMaterial_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool UseMipMap {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxFileTexture_UseMipMap_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool SetFileName(string pName) {
    bool ret = NativeMethods.FbxFileTexture_SetFileName(swigCPtr, pName);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetRelativeFileName(string pName) {
    bool ret = NativeMethods.FbxFileTexture_SetRelativeFileName(swigCPtr, pName);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetFileName() {
    string ret = NativeMethods.FbxFileTexture_GetFileName(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetRelativeFileName() {
    string ret = NativeMethods.FbxFileTexture_GetRelativeFileName(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaterialUse(FbxFileTexture.EMaterialUse pMaterialUse) {
    NativeMethods.FbxFileTexture_SetMaterialUse(swigCPtr, (int)pMaterialUse);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public FbxFileTexture.EMaterialUse GetMaterialUse() {
    FbxFileTexture.EMaterialUse ret = (FbxFileTexture.EMaterialUse)NativeMethods.FbxFileTexture_GetMaterialUse(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxFileTexture other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxFileTexture;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxFileTexture).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxFileTexture a, FbxFileTexture b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxFileTexture a, FbxFileTexture b) {
    return !(a == b);
  }

  public enum EMaterialUse {
    eModelMaterial,
    eDefaultMaterial
  }

}

}
