namespace NustraPrimeraConexionSQLServer
{
 partial class frmProducto
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
   this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
   this.productsTableAdapter = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.ProductsTableAdapter();
   this.tableAdapterManager = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager();
   this.productsDataGridView = new System.Windows.Forms.DataGridView();
   this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.label1 = new System.Windows.Forms.Label();
   this.txtNombre = new System.Windows.Forms.TextBox();
   this.btnBuscar = new System.Windows.Forms.Button();
   this.btnLimpiar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
   this.SuspendLayout();
   // 
   // northwindDataSet
   // 
   this.northwindDataSet.DataSetName = "NorthwindDataSet";
   this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
   // 
   // productsBindingSource
   // 
   this.productsBindingSource.DataMember = "Products";
   this.productsBindingSource.DataSource = this.northwindDataSet;
   // 
   // productsTableAdapter
   // 
   this.productsTableAdapter.ClearBeforeFill = true;
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
   this.tableAdapterManager.SuppliersTableAdapter = null;
   this.tableAdapterManager.TerritoriesTableAdapter = null;
   this.tableAdapterManager.UpdateOrder = NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
   this.productsDataGridView.DataSource = this.productsBindingSource;
   this.productsDataGridView.Location = new System.Drawing.Point(12, 66);
   this.productsDataGridView.Name = "productsDataGridView";
   this.productsDataGridView.ReadOnly = true;
   this.productsDataGridView.RowHeadersVisible = false;
   this.productsDataGridView.Size = new System.Drawing.Size(398, 220);
   this.productsDataGridView.TabIndex = 1;
   // 
   // dataGridViewTextBoxColumn1
   // 
   this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
   this.dataGridViewTextBoxColumn1.HeaderText = "ID";
   this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
   this.dataGridViewTextBoxColumn1.ReadOnly = true;
   this.dataGridViewTextBoxColumn1.Width = 55;
   // 
   // dataGridViewTextBoxColumn2
   // 
   this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
   this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
   this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
   this.dataGridViewTextBoxColumn2.ReadOnly = true;
   this.dataGridViewTextBoxColumn2.Width = 155;
   // 
   // dataGridViewTextBoxColumn6
   // 
   this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
   this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
   this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
   this.dataGridViewTextBoxColumn6.ReadOnly = true;
   // 
   // dataGridViewTextBoxColumn7
   // 
   this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock";
   this.dataGridViewTextBoxColumn7.HeaderText = "Stock";
   this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
   this.dataGridViewTextBoxColumn7.ReadOnly = true;
   this.dataGridViewTextBoxColumn7.Width = 70;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 18);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(107, 13);
   this.label1.TabIndex = 2;
   this.label1.Text = "Nombre de producto:";
   // 
   // txtNombre
   // 
   this.txtNombre.Location = new System.Drawing.Point(15, 34);
   this.txtNombre.Name = "txtNombre";
   this.txtNombre.Size = new System.Drawing.Size(195, 20);
   this.txtNombre.TabIndex = 3;
   // 
   // btnBuscar
   // 
   this.btnBuscar.Location = new System.Drawing.Point(237, 31);
   this.btnBuscar.Name = "btnBuscar";
   this.btnBuscar.Size = new System.Drawing.Size(75, 23);
   this.btnBuscar.TabIndex = 4;
   this.btnBuscar.Text = "Buscar";
   this.btnBuscar.UseVisualStyleBackColor = true;
   this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(318, 31);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 5;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // frmProducto
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(422, 353);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.btnBuscar);
   this.Controls.Add(this.txtNombre);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.productsDataGridView);
   this.Name = "frmProducto";
   this.Text = "frmProducto";
   this.Load += new System.EventHandler(this.frmProducto_Load);
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private NorthwindDataSet northwindDataSet;
  private System.Windows.Forms.BindingSource productsBindingSource;
  private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
  private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
  private System.Windows.Forms.DataGridView productsDataGridView;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtNombre;
  private System.Windows.Forms.Button btnBuscar;
  private System.Windows.Forms.Button btnLimpiar;
 }
}