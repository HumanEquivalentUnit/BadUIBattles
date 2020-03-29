/*
 * Created by SharpDevelop.
 * User: Si
 * Date: 27/03/2020
 * Time: 09:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BadUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			toolTip1 = new ToolTip();
			toolTip1.SetToolTip(this.radioButton3, "12th May 1977");
			toolTip1.SetToolTip(this.radioButton14, "12th Jan 2017");
			toolTip1.SetToolTip(this.radioButton9, "ELVIS LIVES!!");
			
		}
		void RadioButton14CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show("oi oi");
		}
		
		void ToolTip1Popup(object sender, PopupEventArgs e)
		{
	
		}
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show("Error, birthday must be on the approved date list", "No.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
