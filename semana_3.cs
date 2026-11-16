namespace b_d_semana3;

partial class TableForm
{
    private System.ComponentModel.IContainer? components = null;
    private FlowLayoutPanel pnlToolbar = null!;
    private Button btnReload = null!;
    private Button btnAdd = null!;
    private Button btnDelete = null!;
    private Button btnSave = null!;
    private DataGridView dgvTable = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        pnlToolbar = new FlowLayoutPanel();
        btnReload = new Button();
        btnAdd = new Button();
        btnDelete = new Button();
        btnSave = new Button();
        dgvTable = new DataGridView();
        pnlToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
        SuspendLayout();
        // 
        // pnlToolbar
        // 
        pnlToolbar.Controls.Add(btnReload);
        pnlToolbar.Controls.Add(btnAdd);
        pnlToolbar.Controls.Add(btnDelete);
        pnlToolbar.Controls.Add(btnSave);
        pnlToolbar.Dock = DockStyle.Top;
        pnlToolbar.Location = new Point(0, 0);
        pnlToolbar.Name = "pnlToolbar";
        pnlToolbar.Padding = new Padding(8);
        pnlToolbar.Size = new Size(1000, 52);
        pnlToolbar.TabIndex = 0;
        pnlToolbar.WrapContents = false;
        // 
        // btnReload
        // 
        btnReload.AutoSize = true;
        btnReload.Margin = new Padding(4);
        btnReload.Name = "btnReload";
        btnReload.Size = new Size(68, 25);
        btnReload.TabIndex = 0;
        btnReload.Text = "Actualizar";
        btnReload.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.AutoSize = true;
        btnAdd.Margin = new Padding(4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(74, 25);
        btnAdd.TabIndex = 1;
        btnAdd.Text = "Nueva fila";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.AutoSize = true;
        btnDelete.Margin = new Padding(4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(80, 25);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Eliminar fila";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.AutoSize = true;
        btnSave.Margin = new Padding(4);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(108, 25);
        btnSave.TabIndex = 3;
        btnSave.Text = "Guardar cambios";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // dgvTable
        // 
        dgvTable.AllowUserToAddRows = false;
        dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTable.Dock = DockStyle.Fill;
        dgvTable.Location = new Point(0, 52);
        dgvTable.MultiSelect = false;
        dgvTable.Name = "dgvTable";
        dgvTable.RowHeadersWidth = 51;
        dgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTable.Size = new Size(1000, 568);
        dgvTable.TabIndex = 1;
        // 
        // TableForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 620);
        Controls.Add(dgvTable);
        Controls.Add(pnlToolbar);
        MinimumSize = new Size(760, 480);
        Name = "TableForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Formulario de tabla";
        pnlToolbar.ResumeLayout(false);
        pnlToolbar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
        ResumeLayout(false);
    }
}
