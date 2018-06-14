namespace TestCustomScrollBar
{
   using System.Windows.Forms;

   public partial class Form1 : Form
   {
      bool drawScrollbars = true;

      public Form1()
      {
         InitializeComponent();

         this.textBox1.Text = this.scrollBarEx2.Value.ToString();
         this.textBox2.Text = this.scrollBarEx1.Value.ToString();
      }

      private void button1_Click(object sender, System.EventArgs e)
      {
         if (this.drawScrollbars)
         {
            this.drawScrollbars = false;
            this.scrollBarEx1.BeginUpdate();
            this.scrollBarEx2.BeginUpdate();
            this.button1.Text = "Drawing is off";
         }
         else
         {
            this.drawScrollbars = true;
            this.scrollBarEx1.EndUpdate();
            this.scrollBarEx2.EndUpdate();
            this.button1.Text = "Drawing is on";
         }
      }

      private void scrollBarEx1_Scroll(object sender, ScrollEventArgs e)
      {
         this.textBox2.Text = this.scrollBarEx1.Value.ToString();
      }

      private void scrollBarEx2_Scroll(object sender, ScrollEventArgs e)
      {
         this.textBox1.Text = this.scrollBarEx2.Value.ToString();
      }
   }
}
