<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        grMostrarVector = New DataGridView()
        Label1 = New Label()
        CType(grMostrarVector, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(27, 64)
        Button1.Name = "Button1"
        Button1.Size = New Size(743, 109)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' grMostrarVector
        ' 
        grMostrarVector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grMostrarVector.ColumnHeadersVisible = False
        grMostrarVector.EnableHeadersVisualStyles = False
        grMostrarVector.Location = New Point(27, 236)
        grMostrarVector.Name = "grMostrarVector"
        grMostrarVector.RowHeadersVisible = False
        grMostrarVector.RowHeadersWidth = 51
        grMostrarVector.RowTemplate.Height = 29
        grMostrarVector.Size = New Size(743, 79)
        grMostrarVector.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 213)
        Label1.Name = "Label1"
        Label1.Size = New Size(509, 20)
        Label1.TabIndex = 2
        Label1.Text = "Vector formado por los minimos valores de cada fila de la matriz ingresada"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(grMostrarVector)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        CType(grMostrarVector, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents grMostrarVector As DataGridView
    Friend WithEvents Label1 As Label
End Class
