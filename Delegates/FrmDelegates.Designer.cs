
namespace Delegates
{
    partial class FrmDelegates
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
            this.Order = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbCoffee = new System.Windows.Forms.TextBox();
            this.txbDonuts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(199, 226);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(75, 23);
            this.Order.TabIndex = 0;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(235, 71);
            this.txbName.Name = "txbName";
            this.txbName.PlaceholderText = "Enter name";
            this.txbName.Size = new System.Drawing.Size(100, 23);
            this.txbName.TabIndex = 1;
            // 
            // txbCoffee
            // 
            this.txbCoffee.Location = new System.Drawing.Point(235, 123);
            this.txbCoffee.Name = "txbCoffee";
            this.txbCoffee.PlaceholderText = "Coffees orderd";
            this.txbCoffee.Size = new System.Drawing.Size(100, 23);
            this.txbCoffee.TabIndex = 2;
            // 
            // txbDonuts
            // 
            this.txbDonuts.Location = new System.Drawing.Point(235, 171);
            this.txbDonuts.Name = "txbDonuts";
            this.txbDonuts.PlaceholderText = "Donuts orderd";
            this.txbDonuts.Size = new System.Drawing.Size(100, 23);
            this.txbDonuts.TabIndex = 3;
            // 
            // FrmDelegates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 329);
            this.Controls.Add(this.txbDonuts);
            this.Controls.Add(this.txbCoffee);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.Order);
            this.Name = "FrmDelegates";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbCoffee;
        private System.Windows.Forms.TextBox txbDonuts;
    }
}