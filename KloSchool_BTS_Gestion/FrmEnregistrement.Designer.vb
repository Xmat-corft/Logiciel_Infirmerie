<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnregistrement
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
        LblPrenom = New Label()
        LblClasse = New Label()
        LblNom = New Label()
        BtnEnregistrer = New Button()
        TxtNom = New TextBox()
        TxtClasse = New TextBox()
        TxtPrenom = New TextBox()
        SuspendLayout()
        ' 
        ' LblPrenom
        ' 
        LblPrenom.AutoSize = True
        LblPrenom.Location = New Point(120, 155)
        LblPrenom.Name = "LblPrenom"
        LblPrenom.Size = New Size(55, 15)
        LblPrenom.TabIndex = 0
        LblPrenom.Text = "Prénom :"
        ' 
        ' LblClasse
        ' 
        LblClasse.AutoSize = True
        LblClasse.Location = New Point(120, 250)
        LblClasse.Name = "LblClasse"
        LblClasse.Size = New Size(46, 15)
        LblClasse.TabIndex = 1
        LblClasse.Text = "Classe :"
        ' 
        ' LblNom
        ' 
        LblNom.AutoSize = True
        LblNom.Location = New Point(120, 73)
        LblNom.Name = "LblNom"
        LblNom.Size = New Size(92, 15)
        LblNom.TabIndex = 2
        LblNom.Text = "Nom de l'élève :"
        ' 
        ' BtnEnregistrer
        ' 
        BtnEnregistrer.Location = New Point(532, 378)
        BtnEnregistrer.Name = "BtnEnregistrer"
        BtnEnregistrer.Size = New Size(118, 23)
        BtnEnregistrer.TabIndex = 3
        BtnEnregistrer.Text = "ENREGISTRER"
        BtnEnregistrer.UseVisualStyleBackColor = True
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(315, 73)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(192, 23)
        TxtNom.TabIndex = 4
        ' 
        ' TxtClasse
        ' 
        TxtClasse.Location = New Point(300, 242)
        TxtClasse.Name = "TxtClasse"
        TxtClasse.Size = New Size(216, 23)
        TxtClasse.TabIndex = 5
        ' 
        ' TxtPrenom
        ' 
        TxtPrenom.Location = New Point(315, 147)
        TxtPrenom.Name = "TxtPrenom"
        TxtPrenom.Size = New Size(192, 23)
        TxtPrenom.TabIndex = 6
        ' 
        ' FrmEnregistrement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtPrenom)
        Controls.Add(TxtClasse)
        Controls.Add(TxtNom)
        Controls.Add(BtnEnregistrer)
        Controls.Add(LblNom)
        Controls.Add(LblClasse)
        Controls.Add(LblPrenom)
        Name = "FrmEnregistrement"
        Text = "FrmEnregistrement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblPrenom As Label
    Friend WithEvents LblClasse As Label
    Friend WithEvents LblNom As Label
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtClasse As TextBox
    Friend WithEvents TxtPrenom As TextBox
End Class
