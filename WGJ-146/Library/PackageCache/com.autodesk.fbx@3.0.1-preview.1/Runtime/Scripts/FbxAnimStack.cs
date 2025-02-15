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

public class FbxAnimStack : FbxCollection {
  internal FbxAnimStack(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxAnimStack Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxAnimStack_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxAnimStack ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimStack(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxAnimStack Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxAnimStack_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxAnimStack ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimStack(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyString Description {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxAnimStack_Description_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxTimeSpan GetLocalTimeSpan() {
    FbxTimeSpan ret = new FbxTimeSpan(NativeMethods.FbxAnimStack_GetLocalTimeSpan(swigCPtr), true);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLocalTimeSpan(FbxTimeSpan pTimeSpan) {
    NativeMethods.FbxAnimStack_SetLocalTimeSpan(swigCPtr, FbxTimeSpan.getCPtr(pTimeSpan));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxAnimStack other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxAnimStack;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxAnimStack).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxAnimStack a, FbxAnimStack b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxAnimStack a, FbxAnimStack b) {
    return !(a == b);
  }

}

}
