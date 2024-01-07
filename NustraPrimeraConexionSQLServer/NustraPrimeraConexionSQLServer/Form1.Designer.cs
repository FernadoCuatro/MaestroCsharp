namespace NustraPrimeraConexionSQLServer
{
 partial class Form1
 {
  /// <summary>
  /// Variable del diseñador necesaria.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Limpiar los recursos que se estén usando.
  /// </summary>
  /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Código generado por el Diseñador de Windows Forms

  /// <summary>
  /// Método necesario para admitir el Diseñador. No se puede modificar
  /// el contenido de este método con el editor de código.
  /// </summary>
  private void InitializeComponent()
  {
   this.components = new System.ComponentModel.Container();
   this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
   this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
   this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
   this.northwindDataSet = new NustraPrimeraConexionSQLServer.NorthwindDataSet();
   this.label1 = new System.Windows.Forms.Label();
   this.txtIdCategoria = new System.Windows.Forms.TextBox();
   this.btnBuscar = new System.Windows.Forms.Button();
   this.btnLimpiar = new System.Windows.Forms.Button();
   this.categoriesTableAdapter = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
   this.tableAdapterManager = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager();
   this.customerDemographicsTableAdapter1 = new NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.CustomerDemographicsTableAdapter();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtNombre = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtDescripcion = new System.Windows.Forms.TextBox();
   this.btnGuardar = new System.Windows.Forms.Button();
   this.btnCancelar = new System.Windows.Forms.Button();
   this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
   ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
   this.groupBox1.SuspendLayout();
   this.groupBox2.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
   this.SuspendLayout();
   // 
   // categoriesDataGridView
   // 
   this.categoriesDataGridView.AllowUserToAddRows = false;
   this.categoriesDataGridView.AllowUserToResizeColumns = false;
   this.categoriesDataGridView.AllowUserToResizeRows = false;
   this.categoriesDataGridView.AutoGenerateColumns = false;
   this.categoriesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
   this.categoriesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
   this.categoriesDataGridView.DataSource = this.categoriesBindingSource;
   this.categoriesDataGridView.Location = new System.Drawing.Point(23, 76);
   this.categoriesDataGridView.Name = "categoriesDataGridView";
   this.categoriesDataGridView.ReadOnly = true;
   this.categoriesDataGridView.RowHeadersVisible = false;
   this.categoriesDataGridView.Size = new System.Drawing.Size(596, 240);
   this.categoriesDataGridView.TabIndex = 1;
   // 
   // dataGridViewTextBoxColumn1
   // 
   this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
   this.dataGridViewTextBoxColumn1.HeaderText = "ID ";
   this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
   this.dataGridViewTextBoxColumn1.ReadOnly = true;
   this.dataGridViewTextBoxColumn1.Width = 70;
   // 
   // dataGridViewTextBoxColumn2
   // 
   this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
   this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Categoria";
   this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
   this.dataGridViewTextBoxColumn2.ReadOnly = true;
   this.dataGridViewTextBoxColumn2.Width = 150;
   // 
   // dataGridViewTextBoxColumn3
   // 
   this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
   this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
   this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
   this.dataGridViewTextBoxColumn3.ReadOnly = true;
   this.dataGridViewTextBoxColumn3.Width = 200;
   // 
   // dataGridViewImageColumn1
   // 
   this.dataGridViewImageColumn1.DataPropertyName = "Picture";
   this.dataGridViewImageColumn1.HeaderText = "Picture";
   this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
   this.dataGridViewImageColumn1.ReadOnly = true;
   this.dataGridViewImageColumn1.Width = 130;
   // 
   // categoriesBindingSource
   // 
   this.categoriesBindingSource.DataMember = "Categories";
   this.categoriesBindingSource.DataSource = this.northwindDataSet;
   // 
   // northwindDataSet
   // 
   this.northwindDataSet.DataSetName = "NorthwindDataSet";
   this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(6, 26);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(103, 13);
   this.label1.TabIndex = 2;
   this.label1.Text = "Ingrese la categoria:";
   // 
   // txtIdCategoria
   // 
   this.txtIdCategoria.Location = new System.Drawing.Point(115, 23);
   this.txtIdCategoria.Name = "txtIdCategoria";
   this.txtIdCategoria.Size = new System.Drawing.Size(311, 20);
   this.txtIdCategoria.TabIndex = 3;
   // 
   // btnBuscar
   // 
   this.btnBuscar.Location = new System.Drawing.Point(440, 23);
   this.btnBuscar.Name = "btnBuscar";
   this.btnBuscar.Size = new System.Drawing.Size(75, 23);
   this.btnBuscar.TabIndex = 4;
   this.btnBuscar.Text = "Buscar";
   this.btnBuscar.UseVisualStyleBackColor = true;
   this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(521, 23);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 5;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
   this.tableAdapterManager.ProductsTableAdapter = null;
   this.tableAdapterManager.RegionTableAdapter = null;
   this.tableAdapterManager.ShippersTableAdapter = null;
   this.tableAdapterManager.SuppliersTableAdapter = null;
   this.tableAdapterManager.TerritoriesTableAdapter = null;
   this.tableAdapterManager.UpdateOrder = NustraPrimeraConexionSQLServer.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
   // 
   // customerDemographicsTableAdapter1
   // 
   this.customerDemographicsTableAdapter1.ClearBeforeFill = true;
   // 
   // groupBox1
   // 
   this.groupBox1.BackColor = System.Drawing.Color.Transparent;
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.btnLimpiar);
   this.groupBox1.Controls.Add(this.txtIdCategoria);
   this.groupBox1.Controls.Add(this.btnBuscar);
   this.groupBox1.Location = new System.Drawing.Point(23, 12);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(607, 58);
   this.groupBox1.TabIndex = 0;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Busqueda";
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.btnCancelar);
   this.groupBox2.Controls.Add(this.btnGuardar);
   this.groupBox2.Controls.Add(this.txtDescripcion);
   this.groupBox2.Controls.Add(this.txtNombre);
   this.groupBox2.Controls.Add(this.label3);
   this.groupBox2.Controls.Add(this.label2);
   this.groupBox2.Location = new System.Drawing.Point(32, 339);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(587, 128);
   this.groupBox2.TabIndex = 2;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Operaciones";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(20, 25);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(133, 13);
   this.label2.TabIndex = 0;
   this.label2.Text = "Ingrese nombre categoria: ";
   // 
   // txtNombre
   // 
   this.txtNombre.Location = new System.Drawing.Point(159, 22);
   this.txtNombre.Name = "txtNombre";
   this.txtNombre.Size = new System.Drawing.Size(282, 20);
   this.txtNombre.TabIndex = 1;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(19, 58);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(105, 13);
   this.label3.TabIndex = 0;
   this.label3.Text = "Ingrese descripcion: ";
   // 
   // txtDescripcion
   // 
   this.txtDescripcion.Location = new System.Drawing.Point(159, 55);
   this.txtDescripcion.Multiline = true;
   this.txtDescripcion.Name = "txtDescripcion";
   this.txtDescripcion.Size = new System.Drawing.Size(282, 57);
   this.txtDescripcion.TabIndex = 1;
   // 
   // btnGuardar
   // 
   this.btnGuardar.Location = new System.Drawing.Point(462, 41);
   this.btnGuardar.Name = "btnGuardar";
   this.btnGuardar.Size = new System.Drawing.Size(75, 23);
   this.btnGuardar.TabIndex = 2;
   this.btnGuardar.Text = "Guardar";
   this.btnGuardar.UseVisualStyleBackColor = true;
   this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
   // 
   // btnCancelar
   // 
   this.btnCancelar.Location = new System.Drawing.Point(462, 70);
   this.btnCancelar.Name = "btnCancelar";
   this.btnCancelar.Size = new System.Drawing.Size(75, 23);
   this.btnCancelar.TabIndex = 2;
   this.btnCancelar.Text = "Cancelar";
   this.btnCancelar.UseVisualStyleBackColor = true;
   this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
   // 
   // errorDatos
   // 
   this.errorDatos.ContainerControl = this;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(644, 479);
   this.Controls.Add(this.groupBox2);
   this.Controls.Add(this.groupBox1);
   this.Controls.Add(this.categoriesDataGridView);
   this.Name = "Form1";
   this.Text = "Buscador de categorias";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.groupBox2.ResumeLayout(false);
   this.groupBox2.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private NorthwindDataSet northwindDataSet;
  private System.Windows.Forms.BindingSource categoriesBindingSource;
  private NorthwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
  private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
  private System.Windows.Forms.DataGridView categoriesDataGridView;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtIdCategoria;
  private System.Windows.Forms.Button btnBuscar;
  private System.Windows.Forms.Button btnLimpiar;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
  private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
  private NorthwindDataSetTableAdapters.CustomerDemographicsTableAdapter customerDemographicsTableAdapter1;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.Button btnCancelar;
  private System.Windows.Forms.Button btnGuardar;
  private System.Windows.Forms.TextBox txtDescripcion;
  private System.Windows.Forms.TextBox txtNombre;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ErrorProvider errorDatos;
 }
}

