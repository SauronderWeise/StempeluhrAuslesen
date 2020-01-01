<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CmdImport = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StempeluhrDataSet = New Stempeluhr.StempeluhrDataSet()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New Stempeluhr.StempeluhrDataSetTableAdapters.TableTableAdapter()
        Me.MitarbeiterIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StempeluhrDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdImport
        '
        Me.CmdImport.Location = New System.Drawing.Point(0, 0)
        Me.CmdImport.Name = "CmdImport"
        Me.CmdImport.Size = New System.Drawing.Size(75, 23)
        Me.CmdImport.TabIndex = 0
        Me.CmdImport.Text = "Import"
        Me.CmdImport.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MitarbeiterIDDataGridViewTextBoxColumn, Me.NachnameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(8, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(780, 409)
        Me.DataGridView1.TabIndex = 1
        '
        'StempeluhrDataSet
        '
        Me.StempeluhrDataSet.DataSetName = "StempeluhrDataSet"
        Me.StempeluhrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.StempeluhrDataSet
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'MitarbeiterIDDataGridViewTextBoxColumn
        '
        Me.MitarbeiterIDDataGridViewTextBoxColumn.DataPropertyName = "MitarbeiterID"
        Me.MitarbeiterIDDataGridViewTextBoxColumn.HeaderText = "MitarbeiterID"
        Me.MitarbeiterIDDataGridViewTextBoxColumn.Name = "MitarbeiterIDDataGridViewTextBoxColumn"
        '
        'NachnameDataGridViewTextBoxColumn
        '
        Me.NachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname"
        Me.NachnameDataGridViewTextBoxColumn.HeaderText = "Nachname"
        Me.NachnameDataGridViewTextBoxColumn.Name = "NachnameDataGridViewTextBoxColumn"
        '
        'VornameDataGridViewTextBoxColumn
        '
        Me.VornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.HeaderText = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.Name = "VornameDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdImport)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StempeluhrDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdImport As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StempeluhrDataSet As StempeluhrDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As StempeluhrDataSetTableAdapters.TableTableAdapter
    Friend WithEvents MitarbeiterIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NachnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
