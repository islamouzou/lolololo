namespace WindowsFormsApplication8
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.carriereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new WindowsFormsApplication8.inventoryDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.carriereTableAdapter = new WindowsFormsApplication8.inventoryDataSetTableAdapters.CarriereTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carriereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.carriereBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(177, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // carriereBindingSource
            // 
            this.carriereBindingSource.DataMember = "Carriere";
            this.carriereBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDu,
            this.colAu,
            this.colMotif,
            this.colID_Client});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDu
            // 
            this.colDu.FieldName = "Du";
            this.colDu.Name = "colDu";
            this.colDu.Visible = true;
            this.colDu.VisibleIndex = 1;
            // 
            // colAu
            // 
            this.colAu.FieldName = "Au";
            this.colAu.Name = "colAu";
            this.colAu.Visible = true;
            this.colAu.VisibleIndex = 2;
            // 
            // colMotif
            // 
            this.colMotif.FieldName = "Motif";
            this.colMotif.Name = "colMotif";
            this.colMotif.Visible = true;
            this.colMotif.VisibleIndex = 3;
            // 
            // colID_Client
            // 
            this.colID_Client.FieldName = "ID_Client";
            this.colID_Client.Name = "colID_Client";
            this.colID_Client.Visible = true;
            this.colID_Client.VisibleIndex = 4;
            // 
            // carriereTableAdapter
            // 
            this.carriereTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 261);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carriereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private inventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource carriereBindingSource;
        private inventoryDataSetTableAdapters.CarriereTableAdapter carriereTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDu;
        private DevExpress.XtraGrid.Columns.GridColumn colAu;
        private DevExpress.XtraGrid.Columns.GridColumn colMotif;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Client;
    }
}

