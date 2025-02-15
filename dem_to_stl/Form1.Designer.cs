
namespace dem_to_stl
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGenSTL = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonOpenfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonSavefile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxImagesize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownCoeff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMpPx = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMinHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcCoeff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMpPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenSTL
            // 
            this.buttonGenSTL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenSTL.Location = new System.Drawing.Point(84, 208);
            this.buttonGenSTL.Name = "buttonGenSTL";
            this.buttonGenSTL.Size = new System.Drawing.Size(524, 40);
            this.buttonGenSTL.TabIndex = 3;
            this.buttonGenSTL.Text = "generate STL";
            this.buttonGenSTL.UseVisualStyleBackColor = true;
            this.buttonGenSTL.Click += new System.EventHandler(this.buttonGenSTL_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxInput.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxInput.Location = new System.Drawing.Point(84, 8);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.Size = new System.Drawing.Size(524, 19);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TabStop = false;
            // 
            // buttonOpenfile
            // 
            this.buttonOpenfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenfile.Location = new System.Drawing.Point(612, 8);
            this.buttonOpenfile.Name = "buttonOpenfile";
            this.buttonOpenfile.Size = new System.Drawing.Size(24, 20);
            this.buttonOpenfile.TabIndex = 0;
            this.buttonOpenfile.Text = "...";
            this.buttonOpenfile.UseVisualStyleBackColor = true;
            this.buttonOpenfile.Click += new System.EventHandler(this.buttonOpenfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "input file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "output file";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxOutput.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxOutput.Location = new System.Drawing.Point(84, 32);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(524, 19);
            this.textBoxOutput.TabIndex = 2;
            this.textBoxOutput.TabStop = false;
            // 
            // buttonSavefile
            // 
            this.buttonSavefile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavefile.Location = new System.Drawing.Point(612, 32);
            this.buttonSavefile.Name = "buttonSavefile";
            this.buttonSavefile.Size = new System.Drawing.Size(24, 20);
            this.buttonSavefile.TabIndex = 1;
            this.buttonSavefile.Text = "...";
            this.buttonSavefile.UseVisualStyleBackColor = true;
            this.buttonSavefile.Click += new System.EventHandler(this.buttonSavefile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "image size";
            // 
            // textBoxImagesize
            // 
            this.textBoxImagesize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImagesize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxImagesize.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxImagesize.Location = new System.Drawing.Point(84, 60);
            this.textBoxImagesize.Name = "textBoxImagesize";
            this.textBoxImagesize.ReadOnly = true;
            this.textBoxImagesize.Size = new System.Drawing.Size(524, 19);
            this.textBoxImagesize.TabIndex = 1;
            this.textBoxImagesize.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zcoefficient";
            // 
            // numericUpDownCoeff
            // 
            this.numericUpDownCoeff.DecimalPlaces = 3;
            this.numericUpDownCoeff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCoeff.Location = new System.Drawing.Point(84, 92);
            this.numericUpDownCoeff.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownCoeff.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownCoeff.Name = "numericUpDownCoeff";
            this.numericUpDownCoeff.Size = new System.Drawing.Size(120, 19);
            this.numericUpDownCoeff.TabIndex = 2;
            this.numericUpDownCoeff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMpPx
            // 
            this.numericUpDownMpPx.DecimalPlaces = 2;
            this.numericUpDownMpPx.Location = new System.Drawing.Point(124, 48);
            this.numericUpDownMpPx.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownMpPx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMpPx.Name = "numericUpDownMpPx";
            this.numericUpDownMpPx.Size = new System.Drawing.Size(80, 19);
            this.numericUpDownMpPx.TabIndex = 2;
            this.numericUpDownMpPx.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Map scale (m/px)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Min－Max height (m)";
            // 
            // numericUpDownMinHeight
            // 
            this.numericUpDownMinHeight.Location = new System.Drawing.Point(124, 20);
            this.numericUpDownMinHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownMinHeight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownMinHeight.Name = "numericUpDownMinHeight";
            this.numericUpDownMinHeight.Size = new System.Drawing.Size(80, 19);
            this.numericUpDownMinHeight.TabIndex = 0;
            // 
            // numericUpDownMaxHeight
            // 
            this.numericUpDownMaxHeight.Location = new System.Drawing.Point(228, 20);
            this.numericUpDownMaxHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownMaxHeight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxHeight.Name = "numericUpDownMaxHeight";
            this.numericUpDownMaxHeight.Size = new System.Drawing.Size(80, 19);
            this.numericUpDownMaxHeight.TabIndex = 1;
            this.numericUpDownMaxHeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // buttonCalcCoeff
            // 
            this.buttonCalcCoeff.Location = new System.Drawing.Point(228, 48);
            this.buttonCalcCoeff.Name = "buttonCalcCoeff";
            this.buttonCalcCoeff.Size = new System.Drawing.Size(108, 23);
            this.buttonCalcCoeff.TabIndex = 3;
            this.buttonCalcCoeff.Text = "calc Zcoefficient";
            this.buttonCalcCoeff.UseVisualStyleBackColor = true;
            this.buttonCalcCoeff.Click += new System.EventHandler(this.buttonCalcCoeff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numericUpDownMpPx);
            this.groupBox1.Controls.Add(this.numericUpDownMaxHeight);
            this.groupBox1.Controls.Add(this.buttonCalcCoeff);
            this.groupBox1.Controls.Add(this.numericUpDownMinHeight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(84, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 80);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "↑ Calc Zcoefficient (optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "－";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownCoeff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSavefile);
            this.Controls.Add(this.buttonOpenfile);
            this.Controls.Add(this.textBoxImagesize);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonGenSTL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dem_to_stl";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMpPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenSTL;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonOpenfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonSavefile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxImagesize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownCoeff;
        private System.Windows.Forms.NumericUpDown numericUpDownMpPx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownMinHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxHeight;
        private System.Windows.Forms.Button buttonCalcCoeff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}

