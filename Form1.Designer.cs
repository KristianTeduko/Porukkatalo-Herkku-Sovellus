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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backEditButton = new System.Windows.Forms.Button();
            this.editAddButton = new System.Windows.Forms.Button();
            this.euroLabelReccomended = new System.Windows.Forms.Label();
            this.euroLabelOriginal = new System.Windows.Forms.Label();
            this.reccomendedPriceLabel = new System.Windows.Forms.Label();
            this.originalPriceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxReccomendedPrice = new System.Windows.Forms.TextBox();
            this.textBoxOriginalPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabProductList = new System.Windows.Forms.TabPage();
            this.productlistbuttonTable = new System.Windows.Forms.TableLayoutPanel();
            this.printButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.productList = new System.Windows.Forms.ListView();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewGrid)).BeginInit();
            this.tabEditProduct.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabProductList.SuspendLayout();
            this.productlistbuttonTable.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // websiteLinkLabel
            // 
            this.websiteLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.websiteLinkLabel.AutoSize = true;
            this.websiteLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.websiteLinkLabel.Location = new System.Drawing.Point(951, 614);
            this.websiteLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(98, 17);
            this.websiteLinkLabel.TabIndex = 10;
            this.websiteLinkLabel.TabStop = true;
            this.websiteLinkLabel.Text = "Netin Tuotteet";
            this.websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Nettisivu_LinkClicked);
            // 
            // tabPDF
            // 
            this.tabPDF.Controls.Add(this.label1);
            this.tabPDF.Controls.Add(this.previewGrid);
            this.tabPDF.Controls.Add(this.textBoxReceiver);
            this.tabPDF.Controls.Add(this.textBoxDate);
            this.tabPDF.Controls.Add(this.recieverLabel);
            this.tabPDF.Controls.Add(this.dateLabel);
            this.tabPDF.Controls.Add(this.generatePDFButton);
            this.tabPDF.Controls.Add(this.backPDFButton);
            this.tabPDF.Location = new System.Drawing.Point(4, 29);
            this.tabPDF.Margin = new System.Windows.Forms.Padding(2);
            this.tabPDF.Name = "tabPDF";
            this.tabPDF.Padding = new System.Windows.Forms.Padding(2);
            this.tabPDF.Size = new System.Drawing.Size(1056, 728);
            this.tabPDF.TabIndex = 2;
            this.tabPDF.Text = "Tulostus";
            this.tabPDF.UseVisualStyleBackColor = true;
            // 
            // previewGrid
            // 
            this.previewGrid.AllowUserToAddRows = false;
            this.previewGrid.AllowUserToDeleteRows = false;
            this.previewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previewGrid.ColumnHeadersHeight = 32;
            this.previewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.previewGrid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.previewGrid.Location = new System.Drawing.Point(5, 120);
            this.previewGrid.Name = "previewGrid";
            this.previewGrid.RowHeadersWidth = 51;
            this.previewGrid.RowTemplate.Height = 32;
            this.previewGrid.Size = new System.Drawing.Size(1043, 578);
            this.previewGrid.TabIndex = 0;
            // 
            // textBoxReceiver
            // 
            this.textBoxReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxReceiver.Location = new System.Drawing.Point(203, 16);
            this.textBoxReceiver.Name = "textBoxReceiver";
            this.textBoxReceiver.Size = new System.Drawing.Size(300, 38);
            this.textBoxReceiver.TabIndex = 1;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxDate.Location = new System.Drawing.Point(203, 68);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(300, 38);
            this.textBoxDate.TabIndex = 2;
            // 
            // recieverLabel
            // 
            this.recieverLabel.AutoSize = true;
            this.recieverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.recieverLabel.Location = new System.Drawing.Point(18, 22);
            this.recieverLabel.Name = "recieverLabel";
            this.recieverLabel.Size = new System.Drawing.Size(162, 29);
            this.recieverLabel.TabIndex = 3;
            this.recieverLabel.Text = "Vastaanottaja:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dateLabel.Location = new System.Drawing.Point(35, 74);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(145, 29);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Päivämäärä:";
            // 
            // generatePDFButton
            // 
            this.generatePDFButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generatePDFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.generatePDFButton.Location = new System.Drawing.Point(851, 5);
            this.generatePDFButton.Name = "generatePDFButton";
            this.generatePDFButton.Size = new System.Drawing.Size(197, 64);
            this.generatePDFButton.TabIndex = 3;
            this.generatePDFButton.Text = "Luo PDF";
            this.generatePDFButton.UseVisualStyleBackColor = true;
            this.generatePDFButton.Click += new System.EventHandler(this.generatePDFButton_Click);
            // 
            // backPDFButton
            // 
            this.backPDFButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backPDFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backPDFButton.Location = new System.Drawing.Point(851, 75);
            this.backPDFButton.Name = "backPDFButton";
            this.backPDFButton.Size = new System.Drawing.Size(197, 39);
            this.backPDFButton.TabIndex = 4;
            this.backPDFButton.Text = "Takaisin";
            this.backPDFButton.UseVisualStyleBackColor = true;
            this.backPDFButton.Click += new System.EventHandler(this.backPDFButton_Click);
            // 
            // tabEditProduct
            // 
            this.tabEditProduct.Controls.Add(this.tableLayoutPanel1);
            this.tabEditProduct.Controls.Add(this.euroLabelReccomended);
            this.tabEditProduct.Controls.Add(this.euroLabelOriginal);
            this.tabEditProduct.Controls.Add(this.reccomendedPriceLabel);
            this.tabEditProduct.Controls.Add(this.originalPriceLabel);
            this.tabEditProduct.Controls.Add(this.nameLabel);
            this.tabEditProduct.Controls.Add(this.textBoxReccomendedPrice);
            this.tabEditProduct.Controls.Add(this.textBoxOriginalPrice);
            this.tabEditProduct.Controls.Add(this.textBoxName);
            this.tabEditProduct.Location = new System.Drawing.Point(4, 22);
            this.tabEditProduct.Margin = new System.Windows.Forms.Padding(2);
            this.tabEditProduct.Name = "tabEditProduct";
            this.tabEditProduct.Padding = new System.Windows.Forms.Padding(2);
            this.tabEditProduct.Size = new System.Drawing.Size(1056, 735);
            this.tabEditProduct.TabIndex = 1;
            this.tabEditProduct.Text = "Lisää / Muokkaa";
            this.tabEditProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.backEditButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.editAddButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 456);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 276);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // backEditButton
            // 
            this.backEditButton.AutoSize = true;
            this.backEditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backEditButton.Location = new System.Drawing.Point(3, 200);
            this.backEditButton.Name = "backEditButton";
            this.backEditButton.Size = new System.Drawing.Size(1034, 73);
            this.backEditButton.TabIndex = 11;
            this.backEditButton.Text = "Takaisin";
            this.backEditButton.UseVisualStyleBackColor = true;
            this.backEditButton.Click += new System.EventHandler(this.backEditButton_Click);
            // 
            // editAddButton
            // 
            this.editAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editAddButton.Location = new System.Drawing.Point(2, 2);
            this.editAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.editAddButton.Name = "editAddButton";
            this.editAddButton.Size = new System.Drawing.Size(1036, 193);
            this.editAddButton.TabIndex = 8;
            this.editAddButton.Text = "Lisää / Muokkaa";
            this.editAddButton.UseVisualStyleBackColor = true;
            this.editAddButton.Click += new System.EventHandler(this.editAddButton_Click);
            // 
            // euroLabelReccomended
            // 
            this.euroLabelReccomended.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.euroLabelReccomended.AutoSize = true;
            this.euroLabelReccomended.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.euroLabelReccomended.Location = new System.Drawing.Point(622, 254);
            this.euroLabelReccomended.Name = "euroLabelReccomended";
            this.euroLabelReccomended.Size = new System.Drawing.Size(29, 31);
            this.euroLabelReccomended.TabIndex = 10;
            this.euroLabelReccomended.Text = "€";
            // 
            // euroLabelOriginal
            // 
            this.euroLabelOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.euroLabelOriginal.AutoSize = true;
            this.euroLabelOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.euroLabelOriginal.Location = new System.Drawing.Point(916, 254);
            this.euroLabelOriginal.Name = "euroLabelOriginal";
            this.euroLabelOriginal.Size = new System.Drawing.Size(29, 31);
            this.euroLabelOriginal.TabIndex = 9;
            this.euroLabelOriginal.Text = "€";
            // 
            // reccomendedPriceLabel
            // 
            this.reccomendedPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reccomendedPriceLabel.AutoSize = true;
            this.reccomendedPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.reccomendedPriceLabel.Location = new System.Drawing.Point(427, 205);
            this.reccomendedPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reccomendedPriceLabel.Name = "reccomendedPriceLabel";
            this.reccomendedPriceLabel.Size = new System.Drawing.Size(178, 31);
            this.reccomendedPriceLabel.TabIndex = 7;
            this.reccomendedPriceLabel.Text = "Suositushinta";
            // 
            // originalPriceLabel
            // 
            this.originalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.originalPriceLabel.AutoSize = true;
            this.originalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.originalPriceLabel.Location = new System.Drawing.Point(731, 205);
            this.originalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originalPriceLabel.Name = "originalPriceLabel";
            this.originalPriceLabel.Size = new System.Drawing.Size(148, 31);
            this.originalPriceLabel.TabIndex = 6;
            this.originalPriceLabel.Text = "Tukkuhinta";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nameLabel.Location = new System.Drawing.Point(198, 205);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 31);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nimi";
            // 
            // textBoxReccomendedPrice
            // 
            this.textBoxReccomendedPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxReccomendedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxReccomendedPrice.Location = new System.Drawing.Point(411, 251);
            this.textBoxReccomendedPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReccomendedPrice.Name = "textBoxReccomendedPrice";
            this.textBoxReccomendedPrice.Size = new System.Drawing.Size(206, 38);
            this.textBoxReccomendedPrice.TabIndex = 3;
            // 
            // textBoxOriginalPrice
            // 
            this.textBoxOriginalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxOriginalPrice.Location = new System.Drawing.Point(705, 251);
            this.textBoxOriginalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOriginalPrice.Name = "textBoxOriginalPrice";
            this.textBoxOriginalPrice.Size = new System.Drawing.Size(206, 38);
            this.textBoxOriginalPrice.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxName.Location = new System.Drawing.Point(128, 251);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(206, 38);
            this.textBoxName.TabIndex = 0;
            // 
            // tabProductList
            // 
            this.tabProductList.Controls.Add(this.productlistbuttonTable);
            this.tabProductList.Controls.Add(this.websiteLinkLabel);
            this.tabProductList.Controls.Add(this.checkBox1);
            this.tabProductList.Controls.Add(this.productList);
            this.tabProductList.Location = new System.Drawing.Point(4, 29);
            this.tabProductList.Margin = new System.Windows.Forms.Padding(2);
            this.tabProductList.Name = "tabProductList";
            this.tabProductList.Padding = new System.Windows.Forms.Padding(2);
            this.tabProductList.Size = new System.Drawing.Size(1056, 728);
            this.tabProductList.TabIndex = 0;
            this.tabProductList.Text = "Tuote Lista";
            this.tabProductList.UseVisualStyleBackColor = true;
            // 
            // productlistbuttonTable
            // 
            this.productlistbuttonTable.AutoSize = true;
            this.productlistbuttonTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productlistbuttonTable.ColumnCount = 5;
            this.productlistbuttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.productlistbuttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.productlistbuttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.productlistbuttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.productlistbuttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.productlistbuttonTable.Controls.Add(this.printButton, 0, 0);
            this.productlistbuttonTable.Controls.Add(this.addButton, 1, 0);
            this.productlistbuttonTable.Controls.Add(this.deleteButton, 3, 0);
            this.productlistbuttonTable.Controls.Add(this.refreshButton, 4, 0);
            this.productlistbuttonTable.Controls.Add(this.editButton, 2, 0);
            this.productlistbuttonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlistbuttonTable.Location = new System.Drawing.Point(2, 636);
            this.productlistbuttonTable.Name = "productlistbuttonTable";
            this.productlistbuttonTable.RowCount = 1;
            this.productlistbuttonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.productlistbuttonTable.Size = new System.Drawing.Size(1052, 90);
            this.productlistbuttonTable.TabIndex = 11;
            // 
            // printButton
            // 
            this.printButton.AutoSize = true;
            this.printButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.printButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printButton.Location = new System.Drawing.Point(2, 2);
            this.printButton.Margin = new System.Windows.Forms.Padding(2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(206, 86);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Tulosta";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addButton.Location = new System.Drawing.Point(212, 2);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(206, 86);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Lisää Uusi Tuote";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(632, 2);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(206, 86);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Poista Tuote";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.refreshButton.Location = new System.Drawing.Point(842, 2);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(208, 86);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Päivitä Lista";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refeshButton_Click);
            // 
            // editButton
            // 
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editButton.Location = new System.Drawing.Point(422, 2);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(206, 86);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Muokkaa Tuote";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(4, 611);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 22);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Näytetäänkö Netin Tuotteet?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.netButton_changed);
            // 
            // productList
            // 
            this.productList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.productList.HideSelection = false;
            this.productList.Location = new System.Drawing.Point(4, 5);
            this.productList.Margin = new System.Windows.Forms.Padding(2);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(1048, 601);
            this.productList.TabIndex = 7;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabProductList);
            this.tabMain.Controls.Add(this.tabEditProduct);
            this.tabMain.Controls.Add(this.tabPDF);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabMain.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1064, 761);
            this.tabMain.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(423, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voit muokata yllä olevia tietoja  ^";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Piian Herkut - Lähetyslista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPDF.ResumeLayout(false);
            this.tabPDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewGrid)).EndInit();
            this.tabEditProduct.ResumeLayout(false);
            this.tabEditProduct.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabProductList.ResumeLayout(false);
            this.tabProductList.PerformLayout();
            this.productlistbuttonTable.ResumeLayout(false);
            this.productlistbuttonTable.PerformLayout();
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
        private TableLayoutPanel productlistbuttonTable;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}

