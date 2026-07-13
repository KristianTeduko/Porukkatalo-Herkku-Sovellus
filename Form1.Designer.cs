using System.Drawing;
using System.Windows.Forms;

namespace pien_herkun_softa
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
            this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabPDF = new System.Windows.Forms.TabPage();
            this.previewGrid = new System.Windows.Forms.DataGridView();
            this.textBoxReceiver = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.recieverLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.generatePDFButton = new System.Windows.Forms.Button();
            this.backPDFButton = new System.Windows.Forms.Button();
            this.tabEditProduct = new System.Windows.Forms.TabPage();
            this.backEditButton = new System.Windows.Forms.Button();
            this.euroLabelReccomended = new System.Windows.Forms.Label();
            this.euroLabelOriginal = new System.Windows.Forms.Label();
            this.editAddButton = new System.Windows.Forms.Button();
            this.reccomendedPriceLabel = new System.Windows.Forms.Label();
            this.originalPriceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxReccomendedPrice = new System.Windows.Forms.TextBox();
            this.textBoxOriginalPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabProductList = new System.Windows.Forms.TabPage();
            this.productList = new System.Windows.Forms.ListView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewGrid)).BeginInit();
            this.tabEditProduct.SuspendLayout();
            this.tabProductList.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // websiteLinkLabel
            // 
            this.websiteLinkLabel.AutoSize = true;
            this.websiteLinkLabel.Location = new System.Drawing.Point(174, 619);
            this.websiteLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(75, 13);
            this.websiteLinkLabel.TabIndex = 10;
            this.websiteLinkLabel.TabStop = true;
            this.websiteLinkLabel.Text = "Netin Tuotteet";
            this.websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Nettisivu_LinkClicked);
            // 
            // tabPDF
            // 
            this.tabPDF.Controls.Add(this.previewGrid);
            this.tabPDF.Controls.Add(this.textBoxReceiver);
            this.tabPDF.Controls.Add(this.textBoxDate);
            this.tabPDF.Controls.Add(this.recieverLabel);
            this.tabPDF.Controls.Add(this.dateLabel);
            this.tabPDF.Controls.Add(this.generatePDFButton);
            this.tabPDF.Controls.Add(this.backPDFButton);
            this.tabPDF.Location = new System.Drawing.Point(4, 22);
            this.tabPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPDF.Name = "tabPDF";
            this.tabPDF.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPDF.Size = new System.Drawing.Size(1297, 895);
            this.tabPDF.TabIndex = 2;
            this.tabPDF.Text = "Tulostus";
            this.tabPDF.UseVisualStyleBackColor = true;
            // 
            // previewGrid
            // 
            this.previewGrid.AllowUserToAddRows = false;
            this.previewGrid.AllowUserToDeleteRows = false;
            this.previewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previewGrid.ColumnHeadersHeight = 32;
            this.previewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.previewGrid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.previewGrid.Location = new System.Drawing.Point(5, 120);
            this.previewGrid.Name = "previewGrid";
            this.previewGrid.RowHeadersWidth = 51;
            this.previewGrid.RowTemplate.Height = 32;
            this.previewGrid.Size = new System.Drawing.Size(1026, 585);
            this.previewGrid.TabIndex = 0;
            // 
            // textBoxReceiver
            // 
            this.textBoxReceiver.Location = new System.Drawing.Point(139, 14);
            this.textBoxReceiver.Name = "textBoxReceiver";
            this.textBoxReceiver.Size = new System.Drawing.Size(300, 20);
            this.textBoxReceiver.TabIndex = 1;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(139, 49);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(150, 20);
            this.textBoxDate.TabIndex = 2;
            // 
            // recieverLabel
            // 
            this.recieverLabel.AutoSize = true;
            this.recieverLabel.Location = new System.Drawing.Point(11, 19);
            this.recieverLabel.Name = "recieverLabel";
            this.recieverLabel.Size = new System.Drawing.Size(75, 13);
            this.recieverLabel.TabIndex = 3;
            this.recieverLabel.Text = "Vastaanottaja:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(11, 54);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(66, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Päivämäärä:";
            // 
            // generatePDFButton
            // 
            this.generatePDFButton.Location = new System.Drawing.Point(834, 5);
            this.generatePDFButton.Name = "generatePDFButton";
            this.generatePDFButton.Size = new System.Drawing.Size(197, 64);
            this.generatePDFButton.TabIndex = 3;
            this.generatePDFButton.Text = "Luo PDF";
            this.generatePDFButton.UseVisualStyleBackColor = true;
            this.generatePDFButton.Click += new System.EventHandler(this.generatePDFButton_Click);
            // 
            // backPDFButton
            // 
            this.backPDFButton.Location = new System.Drawing.Point(834, 75);
            this.backPDFButton.Name = "backPDFButton";
            this.backPDFButton.Size = new System.Drawing.Size(197, 39);
            this.backPDFButton.TabIndex = 4;
            this.backPDFButton.Text = "Takaisin";
            this.backPDFButton.UseVisualStyleBackColor = true;
            this.backPDFButton.Click += new System.EventHandler(this.backPDFButton_Click);
            // 
            // tabEditProduct
            // 
            this.tabEditProduct.Controls.Add(this.backEditButton);
            this.tabEditProduct.Controls.Add(this.euroLabelReccomended);
            this.tabEditProduct.Controls.Add(this.euroLabelOriginal);
            this.tabEditProduct.Controls.Add(this.editAddButton);
            this.tabEditProduct.Controls.Add(this.reccomendedPriceLabel);
            this.tabEditProduct.Controls.Add(this.originalPriceLabel);
            this.tabEditProduct.Controls.Add(this.nameLabel);
            this.tabEditProduct.Controls.Add(this.textBoxReccomendedPrice);
            this.tabEditProduct.Controls.Add(this.textBoxOriginalPrice);
            this.tabEditProduct.Controls.Add(this.textBoxName);
            this.tabEditProduct.Location = new System.Drawing.Point(4, 22);
            this.tabEditProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEditProduct.Name = "tabEditProduct";
            this.tabEditProduct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEditProduct.Size = new System.Drawing.Size(1297, 895);
            this.tabEditProduct.TabIndex = 1;
            this.tabEditProduct.Text = "Lisää / Muokkaa";
            this.tabEditProduct.UseVisualStyleBackColor = true;
            // 
            // backEditButton
            // 
            this.backEditButton.Location = new System.Drawing.Point(343, 255);
            this.backEditButton.Name = "backEditButton";
            this.backEditButton.Size = new System.Drawing.Size(234, 63);
            this.backEditButton.TabIndex = 11;
            this.backEditButton.Text = "Takaisin";
            this.backEditButton.UseVisualStyleBackColor = true;
            this.backEditButton.Click += new System.EventHandler(this.backEditButton_Click);
            // 
            // euroLabelReccomended
            // 
            this.euroLabelReccomended.AutoSize = true;
            this.euroLabelReccomended.Location = new System.Drawing.Point(542, 118);
            this.euroLabelReccomended.Name = "euroLabelReccomended";
            this.euroLabelReccomended.Size = new System.Drawing.Size(13, 13);
            this.euroLabelReccomended.TabIndex = 10;
            this.euroLabelReccomended.Text = "€";
            // 
            // euroLabelOriginal
            // 
            this.euroLabelOriginal.AutoSize = true;
            this.euroLabelOriginal.Location = new System.Drawing.Point(542, 94);
            this.euroLabelOriginal.Name = "euroLabelOriginal";
            this.euroLabelOriginal.Size = new System.Drawing.Size(13, 13);
            this.euroLabelOriginal.TabIndex = 9;
            this.euroLabelOriginal.Text = "€";
            // 
            // editAddButton
            // 
            this.editAddButton.Location = new System.Drawing.Point(343, 160);
            this.editAddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editAddButton.Name = "editAddButton";
            this.editAddButton.Size = new System.Drawing.Size(234, 90);
            this.editAddButton.TabIndex = 8;
            this.editAddButton.Text = "Lisää / Muokkaa";
            this.editAddButton.UseVisualStyleBackColor = true;
            this.editAddButton.Click += new System.EventHandler(this.editAddButton_Click);
            // 
            // reccomendedPriceLabel
            // 
            this.reccomendedPriceLabel.AutoSize = true;
            this.reccomendedPriceLabel.Location = new System.Drawing.Point(335, 118);
            this.reccomendedPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reccomendedPriceLabel.Name = "reccomendedPriceLabel";
            this.reccomendedPriceLabel.Size = new System.Drawing.Size(73, 13);
            this.reccomendedPriceLabel.TabIndex = 7;
            this.reccomendedPriceLabel.Text = "Suositushinta:";
            // 
            // originalPriceLabel
            // 
            this.originalPriceLabel.AutoSize = true;
            this.originalPriceLabel.Location = new System.Drawing.Point(346, 94);
            this.originalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originalPriceLabel.Name = "originalPriceLabel";
            this.originalPriceLabel.Size = new System.Drawing.Size(64, 13);
            this.originalPriceLabel.TabIndex = 6;
            this.originalPriceLabel.Text = "Tukkuhinta:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(376, 71);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(30, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nimi:";
            // 
            // textBoxReccomendedPrice
            // 
            this.textBoxReccomendedPrice.Location = new System.Drawing.Point(407, 112);
            this.textBoxReccomendedPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxReccomendedPrice.Name = "textBoxReccomendedPrice";
            this.textBoxReccomendedPrice.Size = new System.Drawing.Size(130, 20);
            this.textBoxReccomendedPrice.TabIndex = 3;
            // 
            // textBoxOriginalPrice
            // 
            this.textBoxOriginalPrice.Location = new System.Drawing.Point(407, 89);
            this.textBoxOriginalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOriginalPrice.Name = "textBoxOriginalPrice";
            this.textBoxOriginalPrice.Size = new System.Drawing.Size(130, 20);
            this.textBoxOriginalPrice.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(407, 66);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(130, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // tabProductList
            // 
            this.tabProductList.Controls.Add(this.websiteLinkLabel);
            this.tabProductList.Controls.Add(this.checkBox1);
            this.tabProductList.Controls.Add(this.productList);
            this.tabProductList.Controls.Add(this.refreshButton);
            this.tabProductList.Controls.Add(this.printButton);
            this.tabProductList.Controls.Add(this.deleteButton);
            this.tabProductList.Controls.Add(this.addButton);
            this.tabProductList.Controls.Add(this.editButton);
            this.tabProductList.Location = new System.Drawing.Point(4, 22);
            this.tabProductList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProductList.Name = "tabProductList";
            this.tabProductList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProductList.Size = new System.Drawing.Size(1297, 895);
            this.tabProductList.TabIndex = 0;
            this.tabProductList.Text = "Tuote Lista";
            this.tabProductList.UseVisualStyleBackColor = true;
            // 
            // productList
            // 
            this.productList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.productList.HideSelection = false;
            this.productList.Location = new System.Drawing.Point(4, 5);
            this.productList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(1028, 608);
            this.productList.TabIndex = 7;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(942, 640);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(88, 65);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Päivitä Lista";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refeshButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(4, 640);
            this.printButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(323, 65);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Tulosta";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(765, 640);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(173, 65);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Poista Tuote";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(331, 640);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(240, 65);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Lisää Uusi Tuote";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(575, 640);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(186, 65);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Muokkaa Tuote";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabProductList);
            this.tabMain.Controls.Add(this.tabEditProduct);
            this.tabMain.Controls.Add(this.tabPDF);
            this.tabMain.Location = new System.Drawing.Point(11, 12);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1305, 921);
            this.tabMain.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(5, 618);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Näytetäänkö Netin Tuotteet?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.netButton_changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Piian Herkut - Lähetyslista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPDF.ResumeLayout(false);
            this.tabPDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewGrid)).EndInit();
            this.tabEditProduct.ResumeLayout(false);
            this.tabEditProduct.PerformLayout();
            this.tabProductList.ResumeLayout(false);
            this.tabProductList.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel websiteLinkLabel;
        private System.Windows.Forms.TabPage tabPDF;
        private System.Windows.Forms.DataGridView previewGrid;
        private System.Windows.Forms.TextBox textBoxReceiver;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label recieverLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button generatePDFButton;
        private System.Windows.Forms.Button backPDFButton;
        private System.Windows.Forms.TabPage tabEditProduct;
        private System.Windows.Forms.Button backEditButton;
        private System.Windows.Forms.Label euroLabelReccomended;
        private System.Windows.Forms.Label euroLabelOriginal;
        private System.Windows.Forms.Button editAddButton;
        private System.Windows.Forms.Label reccomendedPriceLabel;
        private System.Windows.Forms.Label originalPriceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxReccomendedPrice;
        private System.Windows.Forms.TextBox textBoxOriginalPrice;
        private System.Windows.Forms.TabPage tabProductList;
        private System.Windows.Forms.ListView productList;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TabControl tabMain;
        private TextBox textBoxName;
        private CheckBox checkBox1;
    }
}

