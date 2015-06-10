package md5847dfcef6143537a37bcecb8ce5ab7d3;


public class Company
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CS419App.Company, CS419App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Company.class, __md_methods);
	}


	public Company () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Company.class)
			mono.android.TypeManager.Activate ("CS419App.Company, CS419App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
