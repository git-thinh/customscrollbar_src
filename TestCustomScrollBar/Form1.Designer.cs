namespace TestCustomScrollBar
{
   partial class Form1
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.scrollBarEx2 = new CustomScrollBar.ScrollBarEx();
            this.scrollBarEx1 = new CustomScrollBar.ScrollBarEx();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "Drawing is on";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // scrollBarEx2
            // 
            this.scrollBarEx2.LargeChange = 30;
            this.scrollBarEx2.Location = new System.Drawing.Point(67, 18);
            this.scrollBarEx2.Name = "scrollBarEx2";
            this.scrollBarEx2.Orientation = CustomScrollBar.ScrollBarOrientation.Horizontal;
            this.scrollBarEx2.Size = new System.Drawing.Size(315, 19);
            this.scrollBarEx2.TabIndex = 1;
            this.scrollBarEx2.Value = 50;
            this.scrollBarEx2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarEx2_Scroll);
            // 
            // scrollBarEx1
            // 
            this.scrollBarEx1.Location = new System.Drawing.Point(33, 18);
            this.scrollBarEx1.Name = "scrollBarEx1";
            this.scrollBarEx1.Opacity = 0.8D;
            this.scrollBarEx1.Size = new System.Drawing.Size(19, 283);
            this.scrollBarEx1.TabIndex = 0;
            this.scrollBarEx1.Value = 70;
            this.scrollBarEx1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarEx1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 311);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scrollBarEx2);
            this.Controls.Add(this.scrollBarEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private CustomScrollBar.ScrollBarEx scrollBarEx1;
      private CustomScrollBar.ScrollBarEx scrollBarEx2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
   }
}

