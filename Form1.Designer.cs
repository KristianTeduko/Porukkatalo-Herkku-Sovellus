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
            this.websiteLinkLabel.Location = new System.Drawing.Point(20, 916);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(90, 16);
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
            this.tabPDF.Location = new System.Drawing.Point(4, 25);
            this.tabPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPDF.Name = "tabPDF";
            this.tabPDF.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPDF.Size = new System.Drawing.Size(1732, 1104);
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
            this.previewGrid.Location = new System.Drawing.Point(7, 148);
            this.previewGrid.Margin = new System.Windows.Forms.Padding(4);
            this.previewGrid.Name = "previewGrid";
            this.previewGrid.RowHeadersWidth = 51;
            this.previewGrid.RowTemplate.Height = 32;
            this.previewGrid.Size = new System.Drawing.Size(1368, 720);
            this.previewGrid.TabIndex = 0;
            // 
            // textBoxReceiver
            // 
            this.textBoxReceiver.Location = new System.Drawing.Point(185, 17);
            this.textBoxReceiver.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReceiver.Name = "textBoxReceiver";
            this.textBoxReceiver.Size = new System.Drawing.Size(399, 22);
            this.textBoxReceiver.TabIndex = 1;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(185, 60);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(199, 22);
            this.textBoxDate.TabIndex = 2;
            // 
            // recieverLabel
            // 
            this.recieverLabel.AutoSize = true;
            this.recieverLabel.Location = new System.Drawing.Point(15, 23);
            this.recieverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recieverLabel.Name = "recieverLabel";
            this.recieverLabel.Size = new System.Drawing.Size(93, 16);
            this.recieverLabel.TabIndex = 3;
            this.recieverLabel.Text = "Vastaanottaja:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(15, 66);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(84, 16);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Päivämäärä:";
            // 
            // generatePDFButton
            // 
            this.generatePDFButton.Location = new System.Drawing.Point(1112, 6);
            this.generatePDFButton.Margin = new System.Windows.Forms.Padding(4);
            this.generatePDFButton.Name = "generatePDFButton";
            this.generatePDFButton.Size = new System.Drawing.Size(263, 79);
            this.generatePDFButton.TabIndex = 3;
            this.generatePDFButton.Text = "Luo PDF";
            this.generatePDFButton.UseVisualStyleBackColor = true;
            this.generatePDFButton.Click += new System.EventHandler(this.generatePDFButton_Click);
            // 
            // backPDFButton
            // 
            this.backPDFButton.Location = new System.Drawing.Point(1112, 92);
            this.backPDFButton.Margin = new System.Windows.Forms.Padding(4);
            this.backPDFButton.Name = "backPDFButton";
            this.backPDFButton.Size = new System.Drawing.Size(263, 48);
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
            this.tabEditProduct.Location = new System.Drawing.Point(4, 25);
            this.tabEditProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEditProduct.Name = "tabEditProduct";
            this.tabEditProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEditProduct.Size = new System.Drawing.Size(1732, 1104);
            this.tabEditProduct.TabIndex = 1;
            this.tabEditProduct.Text = "Lisää / Muokkaa";
            this.tabEditProduct.UseVisualStyleBackColor = true;
            // 
            // backEditButton
            // 
            this.backEditButton.Location = new System.Drawing.Point(457, 314);
            this.backEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.backEditButton.Name = "backEditButton";
            this.backEditButton.Size = new System.Drawing.Size(312, 78);
            this.backEditButton.TabIndex = 11;
            this.backEditButton.Text = "Takaisin";
            this.backEditButton.UseVisualStyleBackColor = true;
            this.backEditButton.Click += new System.EventHandler(this.backEditButton_Click);
            // 
            // euroLabelReccomended
            // 
            this.euroLabelReccomended.AutoSize = true;
            this.euroLabelReccomended.Location = new System.Drawing.Point(723, 145);
            this.euroLabelReccomended.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.euroLabelReccomended.Name = "euroLabelReccomended";
            this.euroLabelReccomended.Size = new System.Drawing.Size(14, 16);
            this.euroLabelReccomended.TabIndex = 10;
            this.euroLabelReccomended.Text = "€";
            // 
            // euroLabelOriginal
            // 
            this.euroLabelOriginal.AutoSize = true;
            this.euroLabelOriginal.Location = new System.Drawing.Point(723, 116);
            this.euroLabelOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.euroLabelOriginal.Name = "euroLabelOriginal";
            this.euroLabelOriginal.Size = new System.Drawing.Size(14, 16);
            this.euroLabelOriginal.TabIndex = 9;
            this.euroLabelOriginal.Text = "€";
            // 
            // editAddButton
            // 
            this.editAddButton.Location = new System.Drawing.Point(457, 197);
            this.editAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editAddButton.Name = "editAddButton";
            this.editAddButton.Size = new System.Drawing.Size(312, 111);
            this.editAddButton.TabIndex = 8;
            this.editAddButton.Text = "Lisää / Muokkaa";
            this.editAddButton.UseVisualStyleBackColor = true;
            this.editAddButton.Click += new System.EventHandler(this.editAddButton_Click);
            // 
            // reccomendedPriceLabel
            // 
            this.reccomendedPriceLabel.AutoSize = true;
            this.reccomendedPriceLabel.Location = new System.Drawing.Point(447, 145);
            this.reccomendedPriceLabel.Name = "reccomendedPriceLabel";
            this.reccomendedPriceLabel.Size = new System.Drawing.Size(89, 16);
            this.reccomendedPriceLabel.TabIndex = 7;
            this.reccomendedPriceLabel.Text = "Suositushinta:";
            // 
            // originalPriceLabel
            // 
            this.originalPriceLabel.AutoSize = true;
            this.originalPriceLabel.Location = new System.Drawing.Point(462, 116);
            this.originalPriceLabel.Name = "originalPriceLabel";
            this.originalPriceLabel.Size = new System.Drawing.Size(75, 16);
            this.originalPriceLabel.TabIndex = 6;
            this.originalPriceLabel.Text = "Tukkuhinta:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(501, 87);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nimi:";
            // 
            // textBoxReccomendedPrice
            // 
            this.textBoxReccomendedPrice.Location = new System.Drawing.Point(543, 138);
            this.textBoxReccomendedPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxReccomendedPrice.Name = "textBoxReccomendedPrice";
            this.textBoxReccomendedPrice.Size = new System.Drawing.Size(172, 22);
            this.textBoxReccomendedPrice.TabIndex = 3;
            // 
            // textBoxOriginalPrice
            // 
            this.textBoxOriginalPrice.Location = new System.Drawing.Point(543, 110);
            this.textBoxOriginalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOriginalPrice.Name = "textBoxOriginalPrice";
            this.textBoxOriginalPrice.Size = new System.Drawing.Size(172, 22);
            this.textBoxOriginalPrice.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(543, 81);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // tabProductList
            // 
            this.tabProductList.Controls.Add(this.productList);
            this.tabProductList.Controls.Add(this.refreshButton);
            this.tabProductList.Controls.Add(this.printButton);
            this.tabProductList.Controls.Add(this.deleteButton);
            this.tabProductList.Controls.Add(this.addButton);
            this.tabProductList.Controls.Add(this.editButton);
            this.tabProductList.Location = new System.Drawing.Point(4, 25);
            this.tabProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProductList.Name = "tabProductList";
            this.tabProductList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProductList.Size = new System.Drawing.Size(1732, 1104);
            this.tabProductList.TabIndex = 0;
            this.tabProductList.Text = "Tuote Lista";
            this.tabProductList.UseVisualStyleBackColor = true;
            // 
            // productList
            // 
            this.productList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.productList.HideSelection = false;
            this.productList.Location = new System.Drawing.Point(5, 6);
            this.productList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(1369, 776);
            this.productList.TabIndex = 7;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1256, 788);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(118, 80);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Päivitä Lista";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refeshButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(5, 788);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(431, 80);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Tulosta";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1020, 788);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(231, 80);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Poista Tuote";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(441, 788);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(320, 80);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Lisää Uusi Tuote";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(767, 788);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(248, 80);
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
            this.tabMain.Location = new System.Drawing.Point(15, 15);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1740, 1133);
            this.tabMain.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 937);
            this.Controls.Add(this.websiteLinkLabel);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Piian Herkut - Lähetyslista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPDF.ResumeLayout(false);
            this.tabPDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewGrid)).EndInit();
            this.tabEditProduct.ResumeLayout(false);
            this.tabEditProduct.PerformLayout();
            this.tabProductList.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

