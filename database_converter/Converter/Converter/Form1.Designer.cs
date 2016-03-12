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
			this.SuspendLayout();
			// 
			// __load
			// 
			this.@__load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__load.Location = new System.Drawing.Point(12, 12);
			this.@__load.Name = "__load";
			this.@__load.Size = new System.Drawing.Size(271, 23);
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
			this.@__databases.Location = new System.Drawing.Point(12, 41);
			this.@__databases.Name = "__databases";
			this.@__databases.Size = new System.Drawing.Size(271, 160);
			this.@__databases.TabIndex = 1;
			// 
			// __convert
			// 
			this.@__convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__convert.Location = new System.Drawing.Point(12, 212);
			this.@__convert.Name = "__convert";
			this.@__convert.Size = new System.Drawing.Size(271, 23);
			this.@__convert.TabIndex = 2;
			this.@__convert.Text = "Convert";
			this.@__convert.UseVisualStyleBackColor = true;
			this.@__convert.Click += new System.EventHandler(this.@__convert_Click);
			// 
			// __progress
			// 
			this.@__progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.@__progress.Location = new System.Drawing.Point(12, 241);
			this.@__progress.Name = "__progress";
			this.@__progress.Size = new System.Drawing.Size(271, 23);
			this.@__progress.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 271);
			this.Controls.Add(this.@__progress);
			this.Controls.Add(this.@__convert);
			this.Controls.Add(this.@__databases);
			this.Controls.Add(this.@__load);
			this.Name = "Form1";
			this.Text = "Converter";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button __load;
		private System.Windows.Forms.ListBox __databases;
		private System.Windows.Forms.Button __convert;
		private System.Windows.Forms.ProgressBar __progress;
	}
}

