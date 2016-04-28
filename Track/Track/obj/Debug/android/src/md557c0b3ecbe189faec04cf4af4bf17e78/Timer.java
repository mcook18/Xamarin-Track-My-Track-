package md557c0b3ecbe189faec04cf4af4bf17e78;


public class Timer
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Track.Resources.values.Timer, Track, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Timer.class, __md_methods);
	}


	public Timer () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Timer.class)
			mono.android.TypeManager.Activate ("Track.Resources.values.Timer, Track, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
