
namespace ApiHW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Int1 = new System.Windows.Forms.TextBox();
            this.TextBox_Int2 = new System.Windows.Forms.TextBox();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.Button_Calc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RButton_Add = new System.Windows.Forms.RadioButton();
            this.RButton_Subtract = new System.Windows.Forms.RadioButton();
            this.RButton_Multiply = new System.Windows.Forms.RadioButton();
            this.RButton_Divide = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Integer 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Integer 2";
            // 
            // TextBox_Int1
            // 
            this.TextBox_Int1.Location = new System.Drawing.Point(114, 39);
            this.TextBox_Int1.Name = "TextBox_Int1";
            this.TextBox_Int1.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Int1.TabIndex = 2;
            // 
            // TextBox_Int2
            // 
            this.TextBox_Int2.Location = new System.Drawing.Point(114, 79);
            this.TextBox_Int2.Name = "TextBox_Int2";
            this.TextBox_Int2.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Int2.TabIndex = 3;
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(114, 231);
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Result.TabIndex = 4;
            // 
            // Button_Calc
            // 
            this.Button_Calc.Location = new System.Drawing.Point(114, 289);
            this.Button_Calc.Name = "Button_Calc";
            this.Button_Calc.Size = new System.Drawing.Size(100, 23);
            this.Button_Calc.TabIndex = 5;
            this.Button_Calc.Text = "Calculate";
            this.Button_Calc.UseVisualStyleBackColor = true;
            this.Button_Calc.Click += new System.EventHandler(this.Button_Calc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // RButton_Add
            // 
            this.RButton_Add.AutoSize = true;
            this.RButton_Add.Checked = true;
            this.RButton_Add.Location = new System.Drawing.Point(114, 107);
            this.RButton_Add.Name = "RButton_Add";
            this.RButton_Add.Size = new System.Drawing.Size(54, 21);
            this.RButton_Add.TabIndex = 7;
            this.RButton_Add.TabStop = true;
            this.RButton_Add.Text = "Add";
            this.RButton_Add.UseVisualStyleBackColor = true;
            // 
            // RButton_Subtract
            // 
            this.RButton_Subtract.AutoSize = true;
            this.RButton_Subtract.Location = new System.Drawing.Point(114, 135);
            this.RButton_Subtract.Name = "RButton_Subtract";
            this.RButton_Subtract.Size = new System.Drawing.Size(82, 21);
            this.RButton_Subtract.TabIndex = 8;
            this.RButton_Subtract.TabStop = true;
            this.RButton_Subtract.Text = "Subtract";
            this.RButton_Subtract.UseVisualStyleBackColor = true;
            // 
            // RButton_Multiply
            // 
            this.RButton_Multiply.AutoSize = true;
            this.RButton_Multiply.Location = new System.Drawing.Point(114, 163);
            this.RButton_Multiply.Name = "RButton_Multiply";
            this.RButton_Multiply.Size = new System.Drawing.Size(76, 21);
            this.RButton_Multiply.TabIndex = 9;
            this.RButton_Multiply.TabStop = true;
            this.RButton_Multiply.Text = "Multiply";
            this.RButton_Multiply.UseVisualStyleBackColor = true;
            // 
            // RButton_Divide
            // 
            this.RButton_Divide.AutoSize = true;
            this.RButton_Divide.Location = new System.Drawing.Point(114, 191);
            this.RButton_Divide.Name = "RButton_Divide";
            this.RButton_Divide.Size = new System.Drawing.Size(68, 21);
            this.RButton_Divide.TabIndex = 10;
            this.RButton_Divide.TabStop = true;
            this.RButton_Divide.Text = "Divide";
            this.RButton_Divide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 351);
            this.Controls.Add(this.RButton_Divide);
            this.Controls.Add(this.RButton_Multiply);
            this.Controls.Add(this.RButton_Subtract);
            this.Controls.Add(this.RButton_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_Calc);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.TextBox_Int2);
            this.Controls.Add(this.TextBox_Int1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "API-Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Int1;
        private System.Windows.Forms.TextBox TextBox_Int2;
        private System.Windows.Forms.TextBox TextBox_Result;
        private System.Windows.Forms.Button Button_Calc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RButton_Add;
        private System.Windows.Forms.RadioButton RButton_Subtract;
        private System.Windows.Forms.RadioButton RButton_Multiply;
        private System.Windows.Forms.RadioButton RButton_Divide;
    }
}

