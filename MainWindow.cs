using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void btn_Clicked (object sender, System.EventArgs e)
	{
		// Initialize the string array
		string[] strStrings = { "Random string", "Another random value from the array", "Randomly selected index" };
		// Choose a random slogan
		Random RandString = new Random();
		// Display the random slogan
		label1.Text = strStrings[RandString.Next(0, strStrings.Length)];
		///throw new System.NotImplementedException ();
	}
}
