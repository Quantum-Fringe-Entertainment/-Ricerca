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

public abstract class FbxEmitter : System.IDisposable, System.IEquatable<FbxEmitter> {
  protected global::System.Runtime.InteropServices.HandleRef swigCPtr { get ; private set; }

  internal FbxEmitter(global::System.IntPtr cPtr, bool ignored) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEmitter obj) {
    return ((object)obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }
  ~FbxEmitter() {
    Dispose(false);
  }
  protected void Dispose(bool disposing) {
    if (swigCPtr.Handle != global::System.IntPtr.Zero) {
      if (disposing) {
        Destroy();
      }
      lock(this) {
        NativeMethods.ReleaseWeakPointerHandle(swigCPtr);
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxEmitter other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxEmitter;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxEmitter).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxEmitter a, FbxEmitter b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxEmitter a, FbxEmitter b) {
    return !(a == b);
  }

  public abstract void Destroy();
  public abstract void Destroy(bool recursive);

}

}
