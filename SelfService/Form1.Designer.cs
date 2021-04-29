
namespace SelfService
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PilihPants = new System.Windows.Forms.Button();
            this.lst_Pants = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.lbl_Cart = new System.Windows.Forms.Label();
            this.btn_PilihShirt = new System.Windows.Forms.Button();
            this.lst_Shirt = new System.Windows.Forms.ListBox();
            this.lst_Cart = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_PilihPants);
            this.groupBox1.Controls.Add(this.lst_Pants);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_PilihShirt);
            this.groupBox1.Controls.Add(this.lst_Shirt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 666);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Produk:";
            // 
            // btn_PilihPants
            // 
            this.btn_PilihPants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PilihPants.Location = new System.Drawing.Point(3, 318);
            this.btn_PilihPants.Name = "btn_PilihPants";
            this.btn_PilihPants.Size = new System.Drawing.Size(643, 33);
            this.btn_PilihPants.TabIndex = 4;
            this.btn_PilihPants.Text = "Pilih";
            this.btn_PilihPants.UseVisualStyleBackColor = true;
            this.btn_PilihPants.Click += new System.EventHandler(this.btn_PilihPants_Click);
            // 
            // lst_Pants
            // 
            this.lst_Pants.Dock = System.Windows.Forms.DockStyle.Top;
            this.lst_Pants.FormattingEnabled = true;
            this.lst_Pants.ItemHeight = 25;
            this.lst_Pants.Location = new System.Drawing.Point(3, 189);
            this.lst_Pants.Name = "lst_Pants";
            this.lst_Pants.Size = new System.Drawing.Size(643, 129);
            this.lst_Pants.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Checkout);
            this.groupBox2.Controls.Add(this.lst_Cart);
            this.groupBox2.Controls.Add(this.lbl_Cart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Checkout.Location = new System.Drawing.Point(183, 52);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(457, 34);
            this.btn_Checkout.TabIndex = 3;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = true;
            // 
            // lbl_Cart
            // 
            this.lbl_Cart.AutoSize = true;
            this.lbl_Cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Cart.Location = new System.Drawing.Point(3, 27);
            this.lbl_Cart.Name = "lbl_Cart";
            this.lbl_Cart.Size = new System.Drawing.Size(94, 25);
            this.lbl_Cart.TabIndex = 1;
            this.lbl_Cart.Text = "Keranjang:";
            // 
            // btn_PilihShirt
            // 
            this.btn_PilihShirt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PilihShirt.Location = new System.Drawing.Point(3, 156);
            this.btn_PilihShirt.Name = "btn_PilihShirt";
            this.btn_PilihShirt.Size = new System.Drawing.Size(643, 33);
            this.btn_PilihShirt.TabIndex = 5;
            this.btn_PilihShirt.Text = "Pilih";
            this.btn_PilihShirt.UseVisualStyleBackColor = true;
            this.btn_PilihShirt.Click += new System.EventHandler(this.btn_PilihShirt_Click);
            // 
            // lst_Shirt
            // 
            this.lst_Shirt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lst_Shirt.FormattingEnabled = true;
            this.lst_Shirt.HorizontalScrollbar = true;
            this.lst_Shirt.ItemHeight = 25;
            this.lst_Shirt.Location = new System.Drawing.Point(3, 27);
            this.lst_Shirt.Name = "lst_Shirt";
            this.lst_Shirt.Size = new System.Drawing.Size(643, 129);
            this.lst_Shirt.TabIndex = 0;
            // 
            // lst_Cart
            // 
            this.lst_Cart.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_Cart.FormattingEnabled = true;
            this.lst_Cart.ItemHeight = 25;
            this.lst_Cart.Location = new System.Drawing.Point(3, 52);
            this.lst_Cart.Name = "lst_Cart";
            this.lst_Cart.Size = new System.Drawing.Size(180, 236);
            this.lst_Cart.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(649, 578);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "                           ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Label lbl_Cart;
        private System.Windows.Forms.ListBox lst_Shirt;
        private System.Windows.Forms.ListBox lst_Pants;
        private System.Windows.Forms.Button btn_PilihPants;
        private System.Windows.Forms.Button btn_PilihShirt;
        private System.Windows.Forms.ListBox lst_Cart;
    }
}

