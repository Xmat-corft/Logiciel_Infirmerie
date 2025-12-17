<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListe2019
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LblTitreListe = New Label()
        BtnAfficher = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblTitreListe
        ' 
        LblTitreListe.AutoSize = True
        LblTitreListe.Location = New Point(253, 102)
        LblTitreListe.Name = "LblTitreListe"
        LblTitreListe.Size = New Size(133, 15)
        LblTitreListe.TabIndex = 0
        LblTitreListe.Text = "LISTE DES ELEVES (2019)"
        ' 
        ' BtnAfficher
        ' 
        BtnAfficher.Location = New Point(434, 384)
        BtnAfficher.Name = "BtnAfficher"
        BtnAfficher.Size = New Size(209, 23)
        BtnAfficher.TabIndex = 1
        BtnAfficher.Text = "CHARGER LA LISTE"
        BtnAfficher.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(215, 171)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 2
        ' 
        ' FrmListe2019
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(BtnAfficher)
        Controls.Add(LblTitreListe)
        Name = "FrmListe2019"
        Text = "FrmListe2019"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblTitreListe As Label
    Friend WithEvents BtnAfficher As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
