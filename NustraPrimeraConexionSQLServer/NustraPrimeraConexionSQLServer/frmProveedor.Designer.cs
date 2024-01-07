namespace NustraPrimeraConexionSQLServer
{
 partial class frmProveedor
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
   this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
   this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.label1 = new System.Windows.Forms.Label();
   this.txtNombre = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
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
   this.tableAdapterManager.ProductsTableAdapter = null;
   this.tableAdapterManager.RegionTableAdapter = null;
   this.tableAdapterManager.ShippersTableAdapter = null;
   this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
   this.tableAdapterManager.TerritoriesTableAdapter = null;
   this.tableAdapterManager.UpdateOrder = NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
   // 
   // suppliersDataGridView
   // 
   this.suppliersDataGridView.AllowUserToAddRows = false;
   this.suppliersDataGridView.AllowUserToResizeColumns = false;
   this.suppliersDataGridView.AllowUserToResizeRows = false;
   this.suppliersDataGridView.AutoGenerateColumns = false;
   this.suppliersDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
   this.suppliersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10});
   this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
   this.suppliersDataGridView.Location = new System.Drawing.Point(12, 48);
   this.suppliersDataGridView.Name = "suppliersDataGridView";
   this.suppliersDataGridView.ReadOnly = true;
   this.suppliersDataGridView.RowHeadersVisible = false;
   this.suppliersDataGridView.Size = new System.Drawing.Size(649, 220);
   this.suppliersDataGridView.TabIndex = 1;
   // 
   // dataGridViewTextBoxColumn1
   // 
   this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierID";
   this.dataGridViewTextBoxColumn1.HeaderText = "ID";
   this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
   this.dataGridViewTextBoxColumn1.ReadOnly = true;
   this.dataGridViewTextBoxColumn1.Width = 50;
   // 
   // dataGridViewTextBoxColumn2
   // 
   this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
   this.dataGridViewTextBoxColumn2.HeaderText = "Compañia";
   this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
   this.dataGridViewTextBoxColumn2.ReadOnly = true;
   this.dataGridViewTextBoxColumn2.Width = 130;
   // 
   // dataGridViewTextBoxColumn3
   // 
   this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactName";
   this.dataGridViewTextBoxColumn3.HeaderText = "Contacto";
   this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
   this.dataGridViewTextBoxColumn3.ReadOnly = true;
   // 
   // dataGridViewTextBoxColumn5
   // 
   this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
   this.dataGridViewTextBoxColumn5.HeaderText = "Direccion";
   this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
   this.dataGridViewTextBoxColumn5.ReadOnly = true;
   this.dataGridViewTextBoxColumn5.Width = 150;
   // 
   // dataGridViewTextBoxColumn6
   // 
   this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
   this.dataGridViewTextBoxColumn6.HeaderText = "Cuidad";
   this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
   this.dataGridViewTextBoxColumn6.ReadOnly = true;
   // 
   // dataGridViewTextBoxColumn10
   // 
   this.dataGridViewTextBoxColumn10.DataPropertyName = "Phone";
   this.dataGridViewTextBoxColumn10.HeaderText = "Telefono";
   this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
   this.dataGridViewTextBoxColumn10.ReadOnly = true;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(292, 7);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(93, 13);
   this.label1.TabIndex = 2;
   this.label1.Text = "Nombre compañia";
   // 
   // txtNombre
   // 
   this.txtNombre.Location = new System.Drawing.Point(221, 24);
   this.txtNombre.Name = "txtNombre";
   this.txtNombre.Size = new System.Drawing.Size(240, 20);
   this.txtNombre.TabIndex = 3;
   this.txtNombre.TextChanged += new System.EventHandler(this.Filtrar);
   // 
   // frmProveedor
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(673, 333);
   this.Controls.Add(this.txtNombre);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.suppliersDataGridView);
   this.Name = "frmProveedor";
   this.Text = "frmProveedor";
   this.Load += new System.EventHandler(this.frmProveedor_Load);
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private NorthwindDataSet northwindDataSet;
  private System.Windows.Forms.BindingSource suppliersBindingSource;
  private NorthwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
  private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
  private System.Windows.Forms.DataGridView suppliersDataGridView;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtNombre;
 }
}