namespace NustraPrimeraConexionSQLServer
{
 partial class FrmProductoProveedor
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
   this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
   this.suppliersTableAdapter = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.SuppliersTableAdapter();
   this.tableAdapterManager = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager();
   this.productsTableAdapter = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.ProductsTableAdapter();
   this.cboProveedor = new System.Windows.Forms.ComboBox();
   this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
   this.productsDataGridView = new System.Windows.Forms.DataGridView();
   this.label1 = new System.Windows.Forms.Label();
   this.btnLimpiar = new System.Windows.Forms.Button();
   this.errorProveedor = new System.Windows.Forms.ErrorProvider(this.components);
   this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.errorProveedor)).BeginInit();
   this.SuspendLayout();
   // 
   // northwindDataSet
   // 
   this.northwindDataSet.DataSetName = "NorthwindDataSet";
   this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
   // 
   // suppliersBindingSource
   // 
   this.suppliersBindingSource.DataMember = "Suppliers";
   this.suppliersBindingSource.DataSource = this.northwindDataSet;
   // 
   // suppliersTableAdapter
   // 
   this.suppliersTableAdapter.ClearBeforeFill = true;
   // 
   // tableAdapterManager
   // 
   this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
   this.tableAdapterManager.CategoriesTableAdapter = null;
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
   this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
   this.tableAdapterManager.TerritoriesTableAdapter = null;
   this.tableAdapterManager.UpdateOrder = NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
   // 
   // productsTableAdapter
   // 
   this.productsTableAdapter.ClearBeforeFill = true;
   // 
   // cboProveedor
   // 
   this.cboProveedor.DataSource = this.suppliersBindingSource;
   this.cboProveedor.DisplayMember = "CompanyName";
   this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cboProveedor.FormattingEnabled = true;
   this.cboProveedor.Location = new System.Drawing.Point(35, 43);
   this.cboProveedor.Name = "cboProveedor";
   this.cboProveedor.Size = new System.Drawing.Size(402, 21);
   this.cboProveedor.TabIndex = 1;
   this.cboProveedor.ValueMember = "SupplierID";
   this.cboProveedor.SelectionChangeCommitted += new System.EventHandler(this.filtrar);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
   this.productsDataGridView.DataSource = this.productsBindingSource;
   this.productsDataGridView.Location = new System.Drawing.Point(35, 70);
   this.productsDataGridView.Name = "productsDataGridView";
   this.productsDataGridView.ReadOnly = true;
   this.productsDataGridView.RowHeadersVisible = false;
   this.productsDataGridView.Size = new System.Drawing.Size(402, 220);
   this.productsDataGridView.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(32, 25);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(62, 13);
   this.label1.TabIndex = 2;
   this.label1.Text = "Proveedor: ";
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(362, 12);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 3;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // errorProveedor
   // 
   this.errorProveedor.ContainerControl = this;
   // 
   // dataGridViewTextBoxColumn1
   // 
   this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
   this.dataGridViewTextBoxColumn1.HeaderText = "ID";
   this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
   this.dataGridViewTextBoxColumn1.ReadOnly = true;
   this.dataGridViewTextBoxColumn1.Width = 50;
   // 
   // dataGridViewTextBoxColumn2
   // 
   this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
   this.dataGridViewTextBoxColumn2.HeaderText = "Product";
   this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
   this.dataGridViewTextBoxColumn2.ReadOnly = true;
   // 
   // dataGridViewTextBoxColumn3
   // 
   this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
   this.dataGridViewTextBoxColumn3.HeaderText = "Price";
   this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
   this.dataGridViewTextBoxColumn3.ReadOnly = true;
   // 
   // dataGridViewTextBoxColumn4
   // 
   this.dataGridViewTextBoxColumn4.DataPropertyName = "UnitsInStock";
   this.dataGridViewTextBoxColumn4.HeaderText = "Stock";
   this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
   this.dataGridViewTextBoxColumn4.ReadOnly = true;
   // 
   // FrmProductoProveedor
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(476, 380);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.productsDataGridView);
   this.Controls.Add(this.cboProveedor);
   this.Name = "FrmProductoProveedor";
   this.Text = "FrmProductoProveedor";
   this.Load += new System.EventHandler(this.FrmProductoProveedor_Load);
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.errorProveedor)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private NorthwindDataSet northwindDataSet;
  private System.Windows.Forms.BindingSource suppliersBindingSource;
  private NorthwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
  private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
  private System.Windows.Forms.ComboBox cboProveedor;
  private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
  private System.Windows.Forms.BindingSource productsBindingSource;
  private System.Windows.Forms.DataGridView productsDataGridView;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnLimpiar;
  private System.Windows.Forms.ErrorProvider errorProveedor;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
 }
}