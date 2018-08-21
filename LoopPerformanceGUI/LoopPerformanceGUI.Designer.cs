using System.Windows.Forms;

namespace LoopPerformanceGUI
{
    partial class LoopPerformanceGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radInteger = new System.Windows.Forms.RadioButton();
            this.radObject = new System.Windows.Forms.RadioButton();
            this.grpLoopType = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfLoops = new System.Windows.Forms.TextBox();
            this.txtObjectData = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.grdResults = new System.Windows.Forms.DataGridView();
            this.grpLoopType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.SuspendLayout();
            // 
            // radInteger
            // 
            this.radInteger.AutoSize = true;
            this.radInteger.Location = new System.Drawing.Point(6, 21);
            this.radInteger.Name = "radInteger";
            this.radInteger.Size = new System.Drawing.Size(73, 21);
            this.radInteger.TabIndex = 0;
            this.radInteger.TabStop = true;
            this.radInteger.Text = "Integer";
            this.radInteger.UseVisualStyleBackColor = true;
            this.radInteger.Click += new System.EventHandler(this.radInteger_Click);
            // 
            // radObject
            // 
            this.radObject.AutoSize = true;
            this.radObject.Location = new System.Drawing.Point(6, 48);
            this.radObject.Name = "radObject";
            this.radObject.Size = new System.Drawing.Size(70, 21);
            this.radObject.TabIndex = 1;
            this.radObject.TabStop = true;
            this.radObject.Text = "Object";
            this.radObject.UseVisualStyleBackColor = true;
            this.radObject.Click += new System.EventHandler(this.radObject_Click);
            // 
            // grpLoopType
            // 
            this.grpLoopType.Controls.Add(this.label1);
            this.grpLoopType.Controls.Add(this.txtNumberOfLoops);
            this.grpLoopType.Controls.Add(this.radInteger);
            this.grpLoopType.Controls.Add(this.radObject);
            this.grpLoopType.Location = new System.Drawing.Point(23, 12);
            this.grpLoopType.Name = "grpLoopType";
            this.grpLoopType.Size = new System.Drawing.Size(319, 82);
            this.grpLoopType.TabIndex = 2;
            this.grpLoopType.TabStop = false;
            this.grpLoopType.Text = "Loop Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Loops";
            // 
            // txtNumberOfLoops
            // 
            this.txtNumberOfLoops.Location = new System.Drawing.Point(111, 47);
            this.txtNumberOfLoops.Name = "txtNumberOfLoops";
            this.txtNumberOfLoops.Size = new System.Drawing.Size(188, 22);
            this.txtNumberOfLoops.TabIndex = 2;
            this.txtNumberOfLoops.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfLoops_TextChanged);
            // 
            // txtObjectData
            // 
            this.txtObjectData.Location = new System.Drawing.Point(29, 125);
            this.txtObjectData.Multiline = true;
            this.txtObjectData.Name = "txtObjectData";
            this.txtObjectData.Size = new System.Drawing.Size(243, 247);
            this.txtObjectData.TabIndex = 3;
            this.txtObjectData.Visible = false;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(371, 33);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 48);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // grdResults
            // 
            this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResults.Location = new System.Drawing.Point(12, 125);
            this.grdResults.Name = "grdResults";
            this.grdResults.RowTemplate.Height = 24;
            this.grdResults.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grdResults.Size = new System.Drawing.Size(776, 381);
            this.grdResults.TabIndex = 5;
            this.grdResults.Visible = false;
            // 
            // LoopPerformanceGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.grdResults);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtObjectData);
            this.Controls.Add(this.grpLoopType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoopPerformanceGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loop Performance GUI";
            this.grpLoopType.ResumeLayout(false);
            this.grpLoopType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radInteger;
        private System.Windows.Forms.RadioButton radObject;
        private System.Windows.Forms.GroupBox grpLoopType;
        private System.Windows.Forms.TextBox txtObjectData;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfLoops;
        private DataGridView grdResults;
    }
}