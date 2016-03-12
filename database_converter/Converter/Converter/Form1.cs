using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;


namespace Converter {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void __load_Click(object sender, EventArgs e) {
			using (var fbd = new FolderBrowserDialog()) {
				if (fbd.ShowDialog(this) != DialogResult.OK) return;
				__databases.Items.Clear();
				foreach (var file in System.IO.Directory.GetFiles(fbd.SelectedPath)) {
					__databases.Items.Add(file);
				}
			}
		}

		private void __convert_Click(object sender, EventArgs e) {
			using (var fbd = new FolderBrowserDialog()) {

				if (fbd.ShowDialog(this) != DialogResult.OK) return;

				__progress.Maximum = __databases.Items.Count;
				__progress.Minimum = 0;
				__progress.Value = 0;

				Application app = new Application {
					Visible = false,
					DisplayAlerts = false
				};

				try {
					foreach (string file in __databases.Items) {
						var wb = app.Workbooks.Open(file);
						try {
							var fileName = System.IO.Path.GetFileNameWithoutExtension(file);
							wb.SaveAs(
								Filename: fbd.SelectedPath + System.IO.Path.DirectorySeparatorChar + fileName + ".csv", 
								FileFormat: XlFileFormat.xlCSV,
								TextCodepage: "UTF-8");
						} finally {
							wb.Close();
						}
						__progress.Value ++;
					}
				} finally {
					app.Quit();
				}
			}
		}
	}
}
