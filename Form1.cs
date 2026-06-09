using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pien_herkun_softa
{
    public partial class Form1 : Form
    {
        // JSON
        private readonly string jsonDataPath = "data.json";
        private List<Product> localProducts = new List<Product>();
        private Product editingProduct = null;
        private List<PrintItem> previewItems = new List<PrintItem>();

        public Form1()
        {
            InitializeComponent();
            SetupListView();

            LoadLocalProducts();

            this.Shown += async (s, e) => await UpdateListViewAsync();
        }

        private void LoadPreview(List<PrintItem> items)
        {
            previewItems = items;

            previewGrid.DataSource = null;
            previewGrid.DataSource = previewItems;

            // Finnish column headers
            previewGrid.Columns["name"].HeaderText = "Tuote";
            previewGrid.Columns["amount"].HeaderText = "Määrä";
            previewGrid.Columns["originalPrice"].HeaderText = "Tukkuhinta";
            previewGrid.Columns["reccomendedPrice"].HeaderText = "Suositushinta";

            textBoxReceiver.Text = "";
            textBoxDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }


        // ---------------- PRODUCT MODEL ----------------
        public class Product
        {
            public string name { get; set; }
            public int amount { get; set; }
            public decimal originalPrice { get; set; }
            public decimal reccomendedPrice { get; set; }
        }

        public class PrintItem
        {
            public string name { get; set; }
            public int amount { get; set; }
            public decimal originalPrice { get; set; }
            public decimal reccomendedPrice { get; set; }
        }



        // ---------------- JSON LOAD / SAVE ----------------
        private void LoadLocalProducts()
        {
            if (File.Exists(jsonDataPath))
            {
                string json = File.ReadAllText(jsonDataPath);
                localProducts = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            }
        }

        private void SaveLocalProducts()
        {
            string json = JsonSerializer.Serialize(localProducts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonDataPath, json);
        }

        // ---------------- LISTVIEW SETUP ----------------
        // ListView1 is the list shows the products
        private void SetupListView()
        {
            productList.View = View.Details;
            productList.FullRowSelect = true;
            productList.GridLines = true;
            productList.CheckBoxes = true;
            productList.MultiSelect = true;

            productList.Columns.Clear();
            productList.Columns.Add("Tuote", 400);
            //listView1.Columns.Add("Hinta (€)", 120);
        }

        // ---------------- SCRAPER ----------------
        public async Task<List<Product>> FetchProductsAsync()
        {
            var clientTemp = new HttpClient();
            clientTemp.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

            byte[] bytes = await clientTemp.GetByteArrayAsync("https://www.kauppa.piianherkut.fi/shop/");
            string html = Encoding.UTF8.GetString(bytes);

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var products = doc.DocumentNode.SelectNodes("//li[contains(@class,'product')]");
            var list = new List<Product>();

            if (products == null)
                return list;

            foreach (var p in products)
            {
                string productName = p.SelectSingleNode(".//h2")?.InnerText?.Trim() ?? "N/A";
                string priceRaw = p.SelectSingleNode(".//*[contains(@class,'price')]")?.InnerText?.Trim() ?? "0";

                productName = System.Net.WebUtility.HtmlDecode(productName);
                priceRaw = System.Net.WebUtility.HtmlDecode(priceRaw);

                priceRaw = priceRaw
                    .Replace("€", "")
                    .Replace("\u00A0", "")
                    .Replace(",", ".")
                    .Trim();

                string numericFilter = System.Text.RegularExpressions.Regex.Match(priceRaw, @"\d+(\.\d+)?").Value;

                decimal.TryParse(
                    numericFilter,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal price
                );

                list.Add(new Product
                {
                    name = productName,
                    amount = 0,
                    reccomendedPrice = price,
                    originalPrice = Math.Round(price / 1.135m, 2)
                });

            }

            return list;
        }

        // ---------------- UPDATE LISTVIEW ----------------
        private async Task UpdateListViewAsync()
        {
            productList.Items.Clear();

            var scraped = await FetchProductsAsync();

            // Scraped products
            foreach (var p in scraped)
            {
                var item = new ListViewItem(p.name + " (Netistä)");
                item.SubItems.Add(p.reccomendedPrice.ToString("0.00") + " €");
                productList.Items.Add(item);
            }

            // Local products (from JSON)
            foreach (var p in localProducts)
            {
                var item = new ListViewItem(p.name);
                item.SubItems.Add(p.reccomendedPrice.ToString("0.00") + " €");
                productList.Items.Add(item);
            }
        }

        // ---------------- FORM EVENTS ----------------
        private async void Form1_Load(object sender, EventArgs e)
        {
            await FetchProductsAsync(); // dont delete!!
        }

        // button1 = update list
        private async void refeshButton_Click(object sender, EventArgs e)
        {
            await UpdateListViewAsync();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            editingProduct = null;

            textBoxName.Text = ""; // name
            textBoxOriginalPrice.Text = ""; // originalPrice
            textBoxReccomendedPrice.Text = ""; // reccomendedPrice

            tabMain.SelectedTab = tabEditProduct;
        }

        // button3 = Edit Product
        private void editButton_Click(object sender, EventArgs e)
        {
            // Block editing multiple products
            if (productList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Valitse ensin tuote.");
                return;
            }

            if (productList.SelectedItems.Count > 1)
            {
                MessageBox.Show("Voit muokata vain yhtä tuotetta kerrallaan.");
                return;
            }

            var selectedItem = productList.SelectedItems[0];
            string rawName = selectedItem.Text;

            if (rawName.EndsWith(" (Netistä)"))
            {
                MessageBox.Show("Netistä tulevia tuotteita ei voi muokata.");
                return;
            }

            string ownName = rawName.Replace(" (OMA)", "");
            editingProduct = localProducts.Find(x => x.name == ownName);
            if (editingProduct == null) return;

            textBoxName.Text = editingProduct.name;
            textBoxOriginalPrice.Text = editingProduct.originalPrice.ToString("0.00");
            textBoxReccomendedPrice.Text = editingProduct.reccomendedPrice.ToString("0.00");

            tabMain.SelectedTab = tabEditProduct;
        }


        // button2 = Delete product
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (productList.SelectedItems.Count == 0) return;

            var selectedItem = productList.SelectedItems[0];
            string rawName = selectedItem.Text;

            if (rawName.EndsWith(" (Netistä)"))
            {
                MessageBox.Show("Netistä tulevia tuotteita ei voi poistaa.");
                return;
            }

            string nameCheck = rawName.Replace(" (Netistä)", "");
            var tuote = localProducts.Find(x => x.name == nameCheck);
            if (tuote == null) return;

            localProducts.Remove(tuote);
            SaveLocalProducts();
            await UpdateListViewAsync();
        }

        private async void editAddButton_Click(object sender, EventArgs e)
        {
            string localName = textBoxName.Text.Trim();
            decimal.TryParse(textBoxOriginalPrice.Text.Trim().Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal tukku);
            decimal.TryParse(textBoxReccomendedPrice.Text.Trim().Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal suositus);

            if (string.IsNullOrWhiteSpace(localName))
            {
                MessageBox.Show("Name ei voi olla tyhjä.");
                return;
            }

            if (editingProduct == null)
            {
                // New product
                var newTemp = new Product
                {
                    name = localName,
                    reccomendedPrice = suositus,
                    originalPrice = Math.Round(suositus / 1.135m, 2)
                };
                localProducts.Add(newTemp);
            }
            else
            {
                // Edit existing
                editingProduct.name = localName;
                editingProduct.reccomendedPrice = suositus;
                editingProduct.originalPrice = Math.Round(suositus / 1.135m, 2);
                editingProduct.reccomendedPrice = suositus;
            }

            SaveLocalProducts();
            MessageBox.Show("Tuote tallennettu.");

            editingProduct = null;
            tabMain.SelectedTab = tabProductList;
            await UpdateListViewAsync();
        }



        // ---------------- MISC EVENTS ----------------
        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in productList.SelectedItems)
                item.Checked = true;
        }




        // Print page
        private void printButton_Click(object sender, EventArgs e)
        {
            var selected = new List<PrintItem>();

            foreach (ListViewItem item in productList.Items)
            {
                if (!item.Checked) continue;

                string nameNet = item.Text.Replace(" (Netistä)", "");
                Product p = localProducts.Find(x => x.name == nameNet);

                if (p == null)
                {
                    decimal reccomendedPriceCalc = decimal.Parse(item.SubItems[1].Text.Replace("€", "").Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

                    selected.Add(new PrintItem
                    {
                        name = nameNet,
                        amount = 1,
                        reccomendedPrice = reccomendedPriceCalc,
                        originalPrice = Math.Round(reccomendedPriceCalc / 1.135m, 2)
                    });
                }

                else
                {
                    selected.Add(new PrintItem
                    {
                        name = p.name,
                        amount = p.amount > 0 ? p.amount : 1,
                        originalPrice = Math.Round(p.reccomendedPrice / 1.135m, 2),
                        reccomendedPrice = p.reccomendedPrice
                    });
                }
            }

            LoadPreview(selected);
            tabMain.SelectedTab = tabPDF;
        }

        private void backPDFButton_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabProductList;
        }

        private void generatePDFButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = "lähetyslista.pdf";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                CreatePdf(sfd.FileName);
            }
        }

        private void CreatePdf(string path)
        {
            var writer = new PdfWriter(path);
            var pdf = new PdfDocument(writer);
            var doc = new Document(pdf);

            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont normal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            // LOGO
            Image logo = new Image(ImageDataFactory.Create("logo.png"))
                .ScaleToFit(60, 60)
                .SetMarginBottom(-30);
            doc.Add(logo);

            // TITLE
            var title = new Paragraph("LÄHETYSLISTA")
                .SetFont(bold)
                .SetFontSize(12)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetMarginTop(0)
                .SetMarginBottom(20);
            doc.Add(title);

            // HEADER BLOCK (Receiver left, Date right)
            Table header = new Table(2).UseAllAvailableWidth();

            header.AddCell(new Cell()
                .Add(new Paragraph("Vastaanottaja:\n" + textBoxReceiver.Text))
                .SetBorder(Border.NO_BORDER)
                .SetFont(normal)
                .SetFontSize(12));

            header.AddCell(new Cell()
                .Add(new Paragraph("Lähetyspäivä: " + textBoxDate.Text))
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER)
                .SetFont(normal)
                .SetFontSize(12));


            doc.Add(header);

            // FOOTER NOTE
            doc.Add(new Paragraph("\nTukkuhinta alv 0%, suositushinta sisältää arvonlisäveron 13,5%.")
                .SetFontSize(10)
                .SetFont(bold));

            doc.Add(new Paragraph("\n"));

            // PRODUCT TABLE (same layout as real company)
            Table table = new Table(new float[] { 4, 1, 2, 2 })
                .UseAllAvailableWidth();

            // HEADER ROW
            table.AddHeaderCell(new Cell().Add(new Paragraph("Tuote").SetFont(bold).SetFontSize(12).SetFontColor(ColorConstants.BLACK)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Määrä").SetFont(bold).SetFontSize(12).SetFontColor(ColorConstants.BLACK)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Tukkuhinta").SetFont(bold).SetFontSize(12).SetFontColor(ColorConstants.BLACK)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Suositushinta").SetFont(bold).SetFontSize(12).SetFontColor(ColorConstants.BLACK)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));

            // ROWS
            foreach (var item in previewItems)
            {
                table.AddCell(new Cell().Add(new Paragraph(item.name)));

                table.AddCell(new Cell().Add(new Paragraph(item.amount.ToString())));

                decimal tukkuTemp = Math.Round(item.reccomendedPrice / 1.135m, 2);
                string tukkuStr = tukkuTemp.ToString("0.00").Replace(".", ",");

                table.AddCell(new Cell().Add(new Paragraph(tukkuStr)));

                string suositusStr = item.reccomendedPrice.ToString("0.00").Replace(".", ",");
                table.AddCell(new Cell().Add(new Paragraph(suositusStr)));
            }

            doc.Add(table);

            doc.Close();

            MessageBox.Show("PDF luotu onnistuneesti!");
        }


        private void Nettisivu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kauppa.piianherkut.fi/shop/");
        }

        private void backEditButton_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabProductList;
        }
    }
}
