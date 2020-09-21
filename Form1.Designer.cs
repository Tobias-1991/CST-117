namespace Inventory4Week7
{
    partial class label1
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
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem51 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem52 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem53 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem54 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem55 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new System.Windows.Forms.ListView();
            this.Inventory = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48,
            listViewItem49,
            listViewItem50,
            listViewItem51,
            listViewItem52,
            listViewItem53,
            listViewItem54,
            listViewItem55});
            this.listView1.Location = new System.Drawing.Point(196, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 237);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Inventory.Location = new System.Drawing.Point(176, 18);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(219, 39);
            this.Inventory.TabIndex = 1;
            this.Inventory.Text = "Inventory List";
            this.Inventory.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Restock Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Display Inventory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Remove Item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 320);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Search For Items";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 404);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.listView1);
            this.Name = "label1";
            this.Text = "Inventory List";
            this.Load += new System.EventHandler(this.label1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

