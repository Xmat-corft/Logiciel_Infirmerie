<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        MenuPrincipal = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        Me.MenuEleves = New ToolStripMenuItem()
        NouvelleÉleveToolStripMenuItem = New ToolStripMenuItem()
        ItemEnregistrement = New ToolStripMenuItem()
        ItemList2019 = New ToolStripMenuItem()
        LblTitre = New Label()
        MenuPrincipal.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuPrincipal
        ' 
        MenuPrincipal.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, Me.MenuEleves, NouvelleÉleveToolStripMenuItem})
        MenuPrincipal.Location = New Point(0, 0)
        MenuPrincipal.Name = "MenuPrincipal"
        MenuPrincipal.Size = New Size(800, 24)
        MenuPrincipal.TabIndex = 0
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(127, 20)
        ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        ' 
        ' MenuEleves
        ' 
        Me.MenuEleves.DropDownItems.AddRange(New ToolStripItem() {ItemEnregistrement, ItemList2019})
        Me.MenuEleves.Name = "MenuEleves"
        Me.MenuEleves.Size = New Size(115, 20)
        Me.MenuEleves.Text = "Gestion des éleves"
        ' 
        ' NouvelleÉleveToolStripMenuItem
        ' 
        NouvelleÉleveToolStripMenuItem.Name = "NouvelleÉleveToolStripMenuItem"
        NouvelleÉleveToolStripMenuItem.Size = New Size(12, 20)
        ' 
        ' ItemEnregistrement
        ' 
        ItemEnregistrement.Name = "ItemEnregistrement"
        ItemEnregistrement.Size = New Size(180, 22)
        ItemEnregistrement.Text = "Nouvel éleve"
        ' 
        ' ItemList2019
        ' 
        ItemList2019.Name = "ItemList2019"
        ItemList2019.Size = New Size(180, 22)
        ItemList2019.Text = "Liste Promo 2019"
        ' 
        ' LblTitre
        ' 
        LblTitre.AutoSize = True
        LblTitre.Location = New Point(213, 199)
        LblTitre.Name = "LblTitre"
        LblTitre.Size = New Size(129, 15)
        LblTitre.TabIndex = 1
        LblTitre.Text = "KLOSCHOOL-GESTION"
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblTitre)
        Controls.Add(MenuPrincipal)
        MainMenuStrip = MenuPrincipal
        Name = "FrmPrincipal"
        Text = "FrmPrincipal"
        MenuPrincipal.ResumeLayout(False)
        MenuPrincipal.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemEnregistrement As ToolStripMenuItem
    Friend WithEvents NouvelleÉleveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemList2019 As ToolStripMenuItem
    Friend WithEvents LblTitre As Label
End Class
