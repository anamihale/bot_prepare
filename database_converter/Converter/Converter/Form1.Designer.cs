namespace Converter {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.@__load = new System.Windows.Forms.Button();
			this.@__databases = new System.Windows.Forms.ListBox();
			this.@__convert = new System.Windows.Forms.Button();
			this.@__progress = new System.Windows.Forms.ProgressBar();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.@__convertBanks = new System.Windows.Forms.Button();
			this.@__convertSynonyms = new System.Windows.Forms.Button();
			this.@__convertNorms = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// __load
			// 
			this.@__load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__load.Location = new System.Drawing.Point(8, 6);
			this.@__load.Name = "__load";
			this.@__load.Size = new System.Drawing.Size(314, 23);
			this.@__load.TabIndex = 0;
			this.@__load.Text = "Load";
			this.@__load.UseVisualStyleBackColor = true;
			this.@__load.Click += new System.EventHandler(this.@__load_Click);
			// 
			// __databases
			// 
			this.@__databases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__databases.FormattingEnabled = true;
			this.@__databases.Location = new System.Drawing.Point(8, 35);
			this.@__databases.Name = "__databases";
			this.@__databases.Size = new System.Drawing.Size(314, 238);
			this.@__databases.TabIndex = 1;
			// 
			// __convert
			// 
			this.@__convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__convert.Location = new System.Drawing.Point(8, 285);
			this.@__convert.Name = "__convert";
			this.@__convert.Size = new System.Drawing.Size(314, 23);
			this.@__convert.TabIndex = 2;
			this.@__convert.Text = "Convert";
			this.@__convert.UseVisualStyleBackColor = true;
			this.@__convert.Click += new System.EventHandler(this.@__convert_Click);
			// 
			// __progress
			// 
			this.@__progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__progress.Location = new System.Drawing.Point(8, 314);
			this.@__progress.Name = "__progress";
			this.@__progress.Size = new System.Drawing.Size(314, 23);
			this.@__progress.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(344, 373);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.@__load);
			this.tabPage1.Controls.Add(this.@__progress);
			this.tabPage1.Controls.Add(this.@__databases);
			this.tabPage1.Controls.Add(this.@__convert);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(336, 347);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Convert DBF to CSV";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.@__convertNorms);
			this.tabPage2.Controls.Add(this.@__convertSynonyms);
			this.tabPage2.Controls.Add(this.@__convertBanks);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(336, 347);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Convert CSV to SQL";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// __convertBanks
			// 
			this.@__convertBanks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__convertBanks.Location = new System.Drawing.Point(8, 6);
			this.@__convertBanks.Name = "__convertBanks";
			this.@__convertBanks.Size = new System.Drawing.Size(320, 23);
			this.@__convertBanks.TabIndex = 0;
			this.@__convertBanks.Text = "Convert Banks";
			this.@__convertBanks.UseVisualStyleBackColor = true;
			this.@__convertBanks.Click += new System.EventHandler(this.@__convertBanks_Click);
			// 
			// __convertSynonyms
			// 
			this.@__convertSynonyms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__convertSynonyms.Location = new System.Drawing.Point(8, 35);
			this.@__convertSynonyms.Name = "__convertSynonyms";
			this.@__convertSynonyms.Size = new System.Drawing.Size(320, 23);
			this.@__convertSynonyms.TabIndex = 1;
			this.@__convertSynonyms.Text = "Convert Synonyms";
			this.@__convertSynonyms.UseVisualStyleBackColor = true;
			this.@__convertSynonyms.Click += new System.EventHandler(this.@__convertSynonyms_Click);
			// 
			// __convertNorms
			// 
			this.@__convertNorms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__convertNorms.Location = new System.Drawing.Point(8, 64);
			this.@__convertNorms.Name = "__convertNorms";
			this.@__convertNorms.Size = new System.Drawing.Size(320, 23);
			this.@__convertNorms.TabIndex = 2;
			this.@__convertNorms.Text = "Convert Norms";
			this.@__convertNorms.UseVisualStyleBackColor = true;
			this.@__convertNorms.Click += new System.EventHandler(this.@__convertNorms_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 373);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Converter";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button __load;
		private System.Windows.Forms.ListBox __databases;
		private System.Windows.Forms.Button __convert;
		private System.Windows.Forms.ProgressBar __progress;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button __convertBanks;
		private System.Windows.Forms.Button __convertSynonyms;
		private System.Windows.Forms.Button __convertNorms;
	}
}

