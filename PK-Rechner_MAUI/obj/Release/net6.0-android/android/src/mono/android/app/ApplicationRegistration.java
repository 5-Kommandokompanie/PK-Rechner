package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("PK_Rechner_MAUI.MainApplication, PK-Rechner, Version=3.0.0.0, Culture=neutral, PublicKeyToken=d8cc046ff16be25d", crc64a11e6de8773962ff.MainApplication.class, crc64a11e6de8773962ff.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
