package crc64a5a37c43dff01024;


public class SpinnerEx
	extends android.widget.Spinner
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setSelection:(I)V:GetSetSelection_IHandler\n" +
			"";
		mono.android.Runtime.register ("Windows.UI.Xaml.Controls.SpinnerEx, Uno.UI", SpinnerEx.class, __md_methods);
	}


	public SpinnerEx (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SpinnerEx.class)
			mono.android.TypeManager.Activate ("Windows.UI.Xaml.Controls.SpinnerEx, Uno.UI", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SpinnerEx (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SpinnerEx.class)
			mono.android.TypeManager.Activate ("Windows.UI.Xaml.Controls.SpinnerEx, Uno.UI", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SpinnerEx (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SpinnerEx.class)
			mono.android.TypeManager.Activate ("Windows.UI.Xaml.Controls.SpinnerEx, Uno.UI", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void setSelection (int p0)
	{
		n_setSelection (p0);
	}

	private native void n_setSelection (int p0);

	private java.util.ArrayList refList;
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
