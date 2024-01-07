namespace NustraPrimeraConexionSQLServer
{
 partial class frmConsultaComboBox
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
   this.components = new System.ComponentModel.Container();
   this.northwindDataSet = new NustraPrimeraConexionSQLServer.NorthwindDataSet();
   this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
   this.categoriesTableAdapter = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
   this.tableAdapterManager = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager();
   this.productsTableAdapter = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.ProductsTableAdapter();
   this.cboCategorias = new System.Windows.Forms.ComboBox();
   this.label1 = new System.Windows.Forms.Label();
   this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
   this.productsDataGridView = new System.Windows.Forms.DataGridView();
   this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.txtConsultar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
   this.SuspendLayout();
   // 
   // northwindDataSet
   // 
   this.northwindDataSet.DataSetName = "NorthwindDataSet";
   this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
   // 
   // categoriesBindingSource
   // 
   this.categoriesBindingSource.DataMember = "Categories";
   this.categoriesBindingSource.DataSource = this.northwindDataSet;
   // 
   // categoriesTableAdapter
   // 
   this.categoriesTableAdapter.ClearBeforeFill = true;
   // 
   // tableAdapterManager
   // 
   this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
   this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
   this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
   this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
   this.tableAdapterManager.CustomersTableAdapter = null;
   this.tableAdapterManager.EmployeesTableAdapter = null;
   this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
   this.tableAdapterManager.Order_DetailsTableAdapter = null;
   this.tableAdapterManager.OrdersTableAdapter = null;
   this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
   this.tableAdapterManager.RegionTableAdapter = null;
   this.tableAdapterManager.ShippersTableAdapter = null;
   this.tableAdapterManager.SuppliersTableAdapter = null;
   this.tableAdapterManager.TerritoriesTableAdapter = null;
   this.tableAdapterManager.UpdateOrder = NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
   // 
   // productsTableAdapter
   // 
   this.productsTableAdapter.ClearBeforeFill = true;
   // 
   // cboCategorias
   // 
   this.cboCategorias.DataSource = this.categoriesBindingSource;
   this.cboCategorias.DisplayMember = "CategoryName";
   this.cboCategorias.FormattingEnabled = true;
   this.cboCategorias.Location = new System.Drawing.Point(94, 13);
   this.cboCategorias.Name = "cboCategorias";
   this.cboCategorias.Size = new System.Drawing.Size(242, 21);
   this.cboCategorias.TabIndex = 1;
   this.cboCategorias.ValueMember = "CategoryID";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(21, 17);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(66, 13);
   this.label1.TabIndex = 2;
   this.label1.Text = "Seleccione: ";
   // 
   // productsBindingSource
   // 
   this.productsBindingSource.DataMember = "Products";
   this.productsBindingSource.DataSource = this.northwindDataSet;
   // 
   // productsDataGridView
   // 
   this.productsDataGridView.AllowUserToAddRows = false;
   this.productsDataGridView.AllowUserToResizeColumns = false;
   this.productsDataGridView.AllowUserToResizeRows = false;
   this.productsDataGridView.AutoGenerateColumns = false;
   this.productsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
   this.productsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitsInStockDataGridViewTextBoxColumn});
   this.productsDataGridView.DataSource = this.productsBindingSource;
   this.productsDataGridView.Location = new System.Drawing.Point(12, 49);
   this.productsDataGridView.Name = "productsDataGridView";
   this.productsDataGridView.ReadOnly = true;
   this.productsDataGridView.RowHeadersVisible = false;
   this.productsDataGridView.Size = new System.Drawing.Size(447, 220);
   this.productsDataGridView.TabIndex = 2;
   // 
   // productIDDataGridViewTextBoxColumn
   // 
   this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
   this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
   this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
   this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
   // 
   // productNameDataGridViewTextBoxColumn
   // 
   this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
   this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
   this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
   this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
   // 
   // unitPriceDataGridViewTextBoxColumn
   // 
   this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
   this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
   this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
   this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
   // 
   // unitsInStockDataGridViewTextBoxColumn
   // 
   this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
   this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
   this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
   this.unitsInStockDataGridViewTextBoxColumn.ReadOnly = true;
   // 
   // txtConsultar
   // 
   this.txtConsultar.Location = new System.Drawing.Point(355, 12);
   this.txtConsultar.Name = "txtConsultar";
   this.txtConsultar.Size = new System.Drawing.Size(75, 23);
   this.txtConsultar.TabIndex = 3;
   this.txtConsultar.Text = "Consultar";
   this.txtConsultar.UseVisualStyleBackColor = true;
   this.txtConsultar.Click += new System.EventHandler(this.txtConsultar_Click);
   // 
   // frmConsultaComboBox
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(471, 332);
   this.Controls.Add(this.txtConsultar);
   this.Controls.Add(this.productsDataGridView);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.cboCategorias);
   this.Name = "frmConsultaComboBox";
   this.Text = "frmConsultaComboBox";
   this.Load += new System.EventHandler(this.frmConsultaComboBox_Load);
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private NorthwindDataSet northwindDataSet;
  private System.Windows.Forms.BindingSource categoriesBindingSource;
  private NorthwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
  private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
  private System.Windows.Forms.ComboBox cboCategorias;
  private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.BindingSource productsBindingSource;
  private System.Windows.Forms.DataGridView productsDataGridView;
  private System.Windows.Forms.Button txtConsultar;
  private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
  private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
  private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
  private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
 }
}